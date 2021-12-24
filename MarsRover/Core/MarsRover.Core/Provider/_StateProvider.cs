using MarsRover.Core.Abstracture;
using MarsRover.Core.Infrastructure;
using MarsRover.Core.Models;
using MarsRover.Core.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.Provider
{
    public class _StateProvider : BaseStateProvider
    {
        public _StateProvider(RoverPosition roverPosition) : base(roverPosition)
        {
            _roverPosition = roverPosition;
        }

        public IStateProvider CreateInstance()
        {
            switch (_roverPosition.Direction)
            {
                case Common.Enums.Direction.S:
                    return new SouthStateProvider(_roverPosition);

                case Common.Enums.Direction.W:
                    return new WestStateProvider(_roverPosition);

                case Common.Enums.Direction.E:
                    return new EastStateProvider(_roverPosition);

                case Common.Enums.Direction.N:
                    return new NorthStateProvider(_roverPosition);

                default:
                    throw new Exception();
            }
        }
    }
}
