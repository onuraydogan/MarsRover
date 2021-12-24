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
    public class GridSize 
    {
        public GridSize(string input)
        {
            ValidateModel(input);
        }

        public int XLimit { get; set; }
        public int YLimit { get; set; }

        public void ValidateModel(string input)
        {
            var splitedInput = input.Split(" ");
            if (splitedInput.Length == 2)
            {
                int xLimit, yLimit;
                if (int.TryParse(splitedInput[0], out xLimit) && int.TryParse(splitedInput[1], out yLimit))
                {
                    if (xLimit > 0 && yLimit > 0)
                    {
                        this.XLimit = xLimit;
                        this.YLimit = yLimit;
                    }
                    else
                    {
                        throw new CustomException("Grid values must be greater than 0",Step.StepGrid);
                    }
                }
                else
                {
                    throw new CustomException("Grid values must be numbers", Step.StepGrid);
                }
            }
            else
            {
                throw new CustomException("Grid values input format is incorrect eg: 5 5", Step.StepGrid);
            }
        }
    }
}
