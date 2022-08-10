using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Utilities.Exceptions
{
    public class EDMException : Exception
    {
        public EDMException()
        {

        }
        public EDMException(string message):base(message)
        {

        }
        public EDMException(string message, Exception inner) : base(message,inner)
        {

        }
    }
}
