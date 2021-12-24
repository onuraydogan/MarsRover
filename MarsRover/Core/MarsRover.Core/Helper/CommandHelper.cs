using MarsRover.Common.Enums;
using MarsRover.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.Helper
{
    public class CommandHelper
    {
        public static List<RoverCommand> Parse(char[] commands)
        {
            List<RoverCommand> roverCommands = new List<RoverCommand>();
            for (int i = 0; i < commands.Length; i++)
            {
                roverCommands.Add(new RoverCommand(commands[i].ToString()));
            }
            return roverCommands;
        }
    }
}
