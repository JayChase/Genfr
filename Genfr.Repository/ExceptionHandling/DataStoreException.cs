using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genfr.Repository.ExceptionHandling
{
    [Serializable]
    public class DataStoreException : ApplicationException
    {
        public DataStoreException()
            : base()
        {
        }

        public DataStoreException(string message)
            : base(message)
        {
        }

        public DataStoreException(string message, IEnumerable<String> errors)
            : base(message)
        {
            this.Errors = errors;
        }

        public DataStoreException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public DataStoreException(string message, Exception innerException, IEnumerable<String> errors)
            : base(message, innerException)
        {
            this.Errors = errors;
        }

        public IEnumerable<String> Errors { get; set; }
    }
}
