using MarsRover.Common.Enums;
using MarsRover.Core.Abstracture;
using MarsRover.Core.Infrastructure;
using MarsRover.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.Provider
{
    public class SouthStateProvider : BaseStateProvider, IStateProvider
    {

        public SouthStateProvider(RoverPosition roverPosition) : base(roverPosition)
        {
            _roverPosition = roverPosition;
        }
 
        public RoverPosition Left()
        {
            _roverPosition.Direction = Direction.E;
            return _roverPosition;
        }

        public RoverPosition Move()
        {
            _roverPosition.Y = _roverPosition.Y - 1;
            return _roverPosition;
        }

        public RoverPosition Rigth()
        {
            _roverPosition.Direction = Direction.W;
            return _roverPosition;
        }
    }
}
