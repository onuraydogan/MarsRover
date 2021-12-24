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
    }
}
