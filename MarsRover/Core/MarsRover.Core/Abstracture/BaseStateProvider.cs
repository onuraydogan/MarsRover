using MarsRover.Core.Infrastructure;
using MarsRover.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.Abstracture
{
    public  class BaseStateProvider
    {
        public RoverPosition _roverPosition;

        public BaseStateProvider(RoverPosition roverPosition)
        {
            _roverPosition = roverPosition;
        }


    }
}
