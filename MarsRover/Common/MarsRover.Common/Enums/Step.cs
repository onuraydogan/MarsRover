using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Common.Enums
{
    public enum Step
    {
        Started = 0,
        StepGrid = 1,
        StepPosition = 2,
        StepCommand = 3,
        //StepRover = 4,
        //StepPlateau = 5,
        Completed = 4
    }
}
