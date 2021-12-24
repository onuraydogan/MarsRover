using MarsRover.Common.Enums;
using MarsRover.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.Models
{
    public class RoverCommand
    {
        public RoverCommand(string command)
        {
            switch (command)
            {
                case "M":
                    this.Command = Command.M;
                    break;
                case "L":
                    this.Command = Command.L;
                    break;
                case "R":
                    this.Command = Command.R;
                    break;
                default:
                    throw new CustomException("Command not defined in the system");
                    
            }
        }
        public Command Command { get; set; }
    }
}
