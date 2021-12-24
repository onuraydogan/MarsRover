using MarsRover.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.Infrastructure
{
    public interface IStateProvider
    {
        public RoverPosition Move();
        public RoverPosition Left();
        public RoverPosition Rigth();
    }
}
