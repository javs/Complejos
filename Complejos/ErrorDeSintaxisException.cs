using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complejos
{
    public class ErrorDeSintaxisException : Exception
    {
        public ErrorDeSintaxisException(string message)
            : base(message)
        {
        }
    }
}
