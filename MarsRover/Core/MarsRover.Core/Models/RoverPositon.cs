using MarsRover.Common.Enums;
using MarsRover.Common.Exceptions;
using MarsRover.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.Models
{
    public class RoverPosition 
    {
        public RoverPosition(string input)
        {
            ValidateModel(input);
        }

        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }

        public void ValidateModel(string input)
        {
            var splitedInput = input.Split(" ");
            if(splitedInput.Length==3)
            {
                int x, y;
                string direction = splitedInput[2];
                if(int.TryParse(splitedInput[0],out x) && int.TryParse(splitedInput[1], out y))
                {
                    if (x > 0 && y > 0)
                    {
                        this.X = x;
                        this.Y = y;
                        switch (direction)
                        {
                            case "N":
                                this.Direction = Direction.N;
                                break;
                            case "E":
                                this.Direction = Direction.E;
                                break;
                            case "W":
                                this.Direction = Direction.W;
                                break;
                            case "S":
                                this.Direction = Direction.S;
                                break;
                            default:
                                throw new CustomException("Position not defined in the system",Step.StepPosition);
                        }
                    }
                    else
                    {
                        throw new CustomException("Position values must be greater than 0", Step.StepPosition);
                    }
                }
            }
            else
            {
                throw new CustomException("Position values input format is incorrect eg: 1 1 N",Step.StepPosition);
            }

        }
    }
}
