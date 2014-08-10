using Genfr.Repository.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genfr.EntityFramework.ExceptionHandling
{
    public class ExceptionHandler : IExceptionHandler
    {
        public ExceptionHandler()
        {
        }

        public ExceptionResult HandleException(Exception exception)
        {
            ExceptionResult exceptionResult = HandleDbEntityValidationException(exception);

            if (!exceptionResult.Handled)
            {
                exceptionResult = HandleDbUpdateException(exception);
            }
            else if(!exceptionResult.Handled)
            {
                exceptionResult = HandleEntityCommandExecutionException(exception);
            }
            else
            {
                exceptionResult = HandleUnknownException(exception);
            }

            return exceptionResult;
        }

        public Exception TranslateException(Exception exception)
        {
            ExceptionResult exceptionResult = HandleDbEntityValidationException(exception);

            if (!exceptionResult.Handled)
            {
                exceptionResult = HandleDbUpdateException(exception);
            }
            else
            {
                exceptionResult = HandleUnknownException(exception);
            }

            if (exceptionResult.Handled)
            {
                return exceptionResult.Exception;
            }
            else
            {
                return exception;
            }
        }

        private ExceptionResult HandleDbEntityValidationException(Exception exception)
        {
            if (exception.GetType() == typeof(DbEntityValidationException))
            {
                var errors = new List<string>();

                foreach (var validationResult in ((DbEntityValidationException)exception).EntityValidationErrors.Where(vr => vr.IsValid == false))
                {
                    foreach (var validationError in validationResult.ValidationErrors)
                    {
                        errors.Add(string.Format("{0} : {1} {2}", validationResult.Entry.Entity.GetType(), validationError.PropertyName, validationError.ErrorMessage));
                    }
                }

                return new ExceptionResult(new DataStoreException("One or more validation errors occurred", errors));
            }
            else
            {
                return new ExceptionResult();
            }
        }

        private ExceptionResult HandleDbUpdateException(Exception exception)
        {
            if (exception.GetType() == typeof(DbUpdateException))
            {
                var errorMessage = exception.GetBaseException().Message;
                string newMessage = "";

                if (errorMessage.Contains("UNQ_"))
                {
                    var errorValue = errorMessage.Substring(errorMessage.IndexOf('(') + 1, errorMessage.IndexOf(')') - errorMessage.IndexOf('(') - 1);

                    var errorColumn = errorMessage.Split('\'')[1].Split('_')[2];

                    newMessage = string.Format("The {0} {1} already exists.", errorColumn, errorValue); ;

                }
                else if (errorMessage.Contains("FK_"))
                {
                    var constraintName = errorMessage.Split('"')[1];

                    var navigationName = constraintName.Split('_')[3];

                    if (navigationName.EndsWith("Id"))
                    {
                        navigationName = navigationName.Substring(0, navigationName.Length - 2);
                    }

                    newMessage = string.Format("Navigation property {0} is required.", navigationName);
                }

                return new ExceptionResult(new DataStoreException(newMessage));
            }
            else
            {
                return new ExceptionResult();
            }
        }

        private ExceptionResult HandleEntityCommandExecutionException(Exception exception)
        {
            if (exception.GetType() == typeof(EntityCommandExecutionException))
            {                
                return new ExceptionResult(new DataStoreException(exception.Message));
            }
            else
            {
                return new ExceptionResult();
            }
        }

        private ExceptionResult HandleUnknownException(Exception exception)
        {
            return new ExceptionResult(new DataStoreException(exception.GetBaseException().Message, exception.GetBaseException()));
        }
    }
}
