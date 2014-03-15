using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genfr.Repository.ExceptionHandling
{
    public class ExceptionResult
    {
        public ExceptionResult()
        {
            this.Handled = false;
        }

        public ExceptionResult(DataStoreException exception)
        {
            this.Handled = true;
            this.Exception = exception;
        }

        public bool Handled { get; set; }

        public DataStoreException Exception { get; set; }
    }
}
