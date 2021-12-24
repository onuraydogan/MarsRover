using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Infrastructure
{
    public interface ICommandProvider
    {
        public void Move();
        public void Left();
        public void Rigth();
    }
}
