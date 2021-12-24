using MarsRover.Common.Exceptions;
using System;
using MarsRover.Core.Extensions;
using MarsRover.Common.Enums;
using MarsRover.Core.Models;
using System.Collections.Generic;

namespace MarsRover.App
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("#### Mars Rover App #### \n\n");

            Step step = Step.Started;
            step = step.Next();

            Plateau plateau = new Plateau();
            GridSize gridSize;
            List<Rover> rovers = new List<Rover>();
            string roverPositionInput = string.Empty;
            char[] roverCommand = { };

            while (step != Step.Completed)
            {
                try
                {
                    if (step == Step.StepGrid)
                    {
                        Console.WriteLine("Enter Plateau Grid Size Eg: 5 5");
                        string gridInput = Console.ReadLine();
                        gridSize = new GridSize(gridInput);
                        plateau.GridSize = gridSize;
                        step = step.Next();
                    }

                    if (step == Step.StepPosition || step == Step.StepCommand)
                    {
                        bool isEnterNewRover = true;
                        while (isEnterNewRover)
                        {
                            if (step == Step.StepPosition)
                            {
                                Console.WriteLine("Enter Rover Position Eg: 1 3 N");
                                roverPositionInput = Console.ReadLine();
                                step = step.Next();
                            }
                            if (step == Step.StepCommand)
                            {
                                Console.WriteLine("Enter Rover Command Eg: LMLRMLMR");
                                roverCommand = Console.ReadLine().ToCharArray();
                                step = step.Next();
                            }

                            rovers.Add(new Rover(roverPositionInput, roverCommand));

                            Console.WriteLine("Do You Want Enter Another Rover ? (Y)");
                            string key = Console.ReadLine();
                            if (key != "Y")
                            {
                                step = Step.Completed;
                                isEnterNewRover = false;
                            }
                        }
                    }
                    plateau.Rovers = rovers;
                }
                catch (CustomException excp)
                {
                    step = excp.CustomExcpStep();
                    Console.WriteLine(string.Format("--Custom Error: {0}", excp.CustomExcpMessage()));
                }
                catch (Exception excp)
                {
                    Console.WriteLine(string.Format("--System Error: {0}", excp.Message));
                    step = Step.StepGrid;
                }
            }

            int i = 1;

            foreach (var rover in rovers)
            {
                rover.Explore(); // ExecuteCommand
                Console.WriteLine(string.Format("Rover {0} => Position: {1} ", i, rover.RoverPosition.StrPosition()));
            }

        }
    }
}
