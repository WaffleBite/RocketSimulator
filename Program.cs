using RocketSimulator.Domain;
using System;
using System.Collections.Generic;
using System.Threading;

namespace RocketSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rocket> simulatedRockets = new List<Rocket>(); //lista med raketer användaren har lagt till

            FalconHeavy falconHeavySpaceX = new FalconHeavy();
            Starship starshipSpaceX = new Starship();

            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("[1] Add rockets");
                Console.WriteLine("[2] List rockets");
                Console.WriteLine("[3] Run simulation");
                Console.WriteLine("[4] Exit");

                ConsoleKeyInfo keyPressed = Console.ReadKey(true);

                Console.Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1: //add rockets
                        //listar raketer som finns, som användaren kan välja mellan, och de läggs i i en "simulator" lista
                        Console.WriteLine("[1] Falcon Heavy, SpaceX");
                        Console.WriteLine("[2] Starship, SpaceX");

                        switch (keyPressed.Key)
                        {
                            case ConsoleKey.D1: //add Falcon Heavy

                                foreach (var therocket in simulatedRockets)
                                {
                                    if (therocket.Name == falconHeavySpaceX.Name)
                                    {
                                        Console.WriteLine("Rocket already added");
                                        Thread.Sleep(2000);
                                    }
                                    else
                                    {
                                        simulatedRockets.Add(falconHeavySpaceX);
                                        Console.WriteLine("Rocked added");

                                        Thread.Sleep(2000);
                                    }
                                }
                                break;

                            case ConsoleKey.D2: //add Starship

                                foreach (var therocket in simulatedRockets)
                                {
                                    if (therocket.Name == starshipSpaceX.Name)
                                    {
                                        Console.WriteLine("Rocket already added");
                                        Thread.Sleep(2000);
                                    }
                                    else
                                    {
                                        simulatedRockets.Add(starshipSpaceX);
                                        Console.WriteLine("Rocked added");

                                        Thread.Sleep(2000);
                                    }
                                }
                                break;
                        }

                        break;

                    case ConsoleKey.D2: //list rockets
                                        //listar raketerna som användaren har valt
                        Console.WriteLine("Simulated rockets");
                        Console.WriteLine("___________________________________________________________");

                        foreach (var listRockets in simulatedRockets)
                        {
                            if (listRockets == null) continue;
                            Console.WriteLine(Rocket.name);
                        }

                        break;

                    case ConsoleKey.D3: //run simulation

                        Console.Write("Engine burn period (sec): ");

                        Console.Write("Rocket".PadRight(30, ' '));
                        Console.Write("Velocity (km/s)".PadRight(20, ' '));
                        Console.Write("Fuel left (tons)");

                        foreach () ...

                        string rocketName = rocket.ToString();
                        string velocity = string.Format("{0:0.00}", Rocket.VelocityInKilometersPerSecond);
                        uint fuelLeftInTons = Rocket.fuelAmountInKilograms / 1000;

                        Console.Write(rocketName.PadRight(30, ' '));
                        Console.Write(velocity.PadRight(20, ' '));
                        Console.Write(fuelLeftInTons);


                        break;

                    case ConsoleKey.D4: //exit

                        isRunning = false;

                        break;
                }




            }
        }
    }
}
