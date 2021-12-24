using MarsRover.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Common.Exceptions
{
    public class CustomException : Exception
    {

        public CustomException(string excp, Step step)
       : base(string.Format("{0}-{1}", (int)step, excp))
        {

        }
    }
}
