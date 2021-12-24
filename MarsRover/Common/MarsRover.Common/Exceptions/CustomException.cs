using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Common.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException(string excp)
       : base(excp)
        {

        }
    }
}
