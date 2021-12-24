using MarsRover.Common.Enums;
using MarsRover.Core.Helper;
using MarsRover.Core.Infrastructure;
using MarsRover.Core.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Core.Extensions;

namespace MarsRover.Core.Models
{
    public class Rover
    {
        public RoverPosition RoverPosition { get; set; }
        public List<RoverCommand> RoverCommands { get; set; }

        public Rover(string positionInput, char[] commands)
        {
            RoverPosition = new RoverPosition(positionInput);
            RoverCommands = CommandHelper.Parse(commands);

        }

        public void Explore()
        {
            foreach (var roverCommand in RoverCommands)
            {
                switch (roverCommand.Command)
                {
                    case Command.M:
                        this.RoverPosition = new _StateProvider(this.RoverPosition).CreateInstance().Move();
                        break;

                    case Command.R:
                        this.RoverPosition = new _StateProvider(this.RoverPosition).CreateInstance().Rigth();
                        break;

                    case Command.L:
                        this.RoverPosition = new _StateProvider(this.RoverPosition).CreateInstance().Left();
                        break;
                }
            }
        }
    }
}
