using MarsRover.Common.Enums;
using MarsRover.Common.Exceptions;
using MarsRover.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.Extensions
{
    public static class Extensions
    {
        public static string StrPosition(this RoverPosition roverPosition)
        {
            return string.Format("{0} {1} {2}", roverPosition.X, roverPosition.Y, roverPosition.Direction.ToString());
        }

        public static Step CustomExcpStep(this CustomException customException)
        {
            var splitedExcp = customException.Message.Split("-");

            return (Step)int.Parse(splitedExcp[0]);
        }
        public static string CustomExcpMessage(this CustomException customException)
        {
            var splitedExcp = customException.Message.Split("-");
            return splitedExcp[1];
        }
        public static Step Next(this Step step)
        {
            return  (Step)((int)step + 1);
        }
    }
}
