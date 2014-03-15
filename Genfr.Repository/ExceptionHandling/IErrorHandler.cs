using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genfr.Repository.ExceptionHandling
{
    public interface IExceptionHandler
    {
        ExceptionResult HandleException(Exception exception);

        Exception TranslateException(Exception exception);
    }
}
