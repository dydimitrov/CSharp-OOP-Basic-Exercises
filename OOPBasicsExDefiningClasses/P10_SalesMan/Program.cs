using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_SalesMan
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var listOfEngines = new List<Engine>();

            for (int i = 0; i < lines; i++)
            {
                var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Engine currentEngine = new Engine();
                currentEngine.Model = line[0];
                currentEngine.Power = int.Parse(line[1]);

                if (line.Length >= 3)
                {
                    if (int.TryParse(line[2], out int result))
                    {
                        currentEngine.Displacement = result;
                    }
                    else
                    {
                        currentEngine.Efficiency = line[2];
                    }
                }
                if (line.Length >= 4)
                {
                    currentEngine.Efficiency = line[3];
                }
                listOfEngines.Add(currentEngine);
            }

            var secondLines = int.Parse(Console.ReadLine());
            var listOfCars = new List<Car>();

            for (int i = 0; i < secondLines; i++)
            {
                var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Car car = new Car();
                car.Model = line[0];
                car.Engine = listOfEngines.Find(e => e.Model == line[1]);

                if (line.Length >= 3)
                {
                    if (int.TryParse(line[2], out int result))
                    {
                        car.Weight = result;
                    }
                    else
                    {
                        car.Color = line[2];
                    }
                    
                }
                if (line.Length >= 4)
                {
                    car.Color = line[3];
                }
                listOfCars.Add(car);
            }

            foreach (var car in listOfCars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement == 0)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                if (car.Weight == 0)
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                Console.WriteLine($"  Color: {car.Color}");
            }

        }
    }
}
