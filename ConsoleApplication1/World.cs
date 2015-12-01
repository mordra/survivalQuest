using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class World
    {
        List<Animal> _animals;

        public void Populate()
        {
            //var numberOfEnums = Enum.GetValues(typeof(Animal)).Cast<Animal>().Last();
            var totalAnimals = 4;
            _animals = new List<Animal>();
            for (var i = 0; i < totalAnimals; i++)
            {
                switch (Dice.D(12)-1)
                {
                    case 0:
                        _animals.Add(new Chicken("Chicken_" + i));
                        break;
                    case 1:
                        _animals.Add(new Rabbit("Rabbit_" + i));
                        break;
                    case 2:
                        _animals.Add(new Bear("Bear_" + i));
                        break;
                    case 3:
                        _animals.Add(new Koala("Koala_" + i));
                        break;
                    case 4:
                        _animals.Add(new Buffalo("Buffalo_" + i));
                        break;
                    case 5:
                        _animals.Add(new Giraffe("Giraffe_" + i));
                        break;
                    case 6:
                        _animals.Add(new Monkey("Monkey_" + i));
                        break;
                    case 7:
                        _animals.Add(new Snake("Snake_" + i));
                        break;
                    case 8:
                        _animals.Add(new Hawk("Hawk_" + i));
                        break;
                    case 9:
                        _animals.Add(new Owl("Owl_" + i));
                        break;
                    case 10:
                        _animals.Add(new Frog("Frog_" + i));
                        break;
                    case 11:
                        _animals.Add(new Camel("Camel_" + i));
                        break;
                    default:
                        // do nothing - should never be executed
                        throw new Exception();
                }
            }
        }

        public void Run()
        {
            Console.WriteLine("Press ESC to stop");
            do
            {
                // output action and outcome for each animal
                foreach (var animal in _animals)
                {
                    Console.WriteLine(animal);
                }

                // each animal will take an action - turn based
                while (!Console.KeyAvailable)
                {
                    foreach (var animal in _animals)
                    {
                        animal.DoAction();
                    }
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            Console.WriteLine("Out of the infinite loop now. Press <ENTER> to exit.");
            Console.ReadLine();

        }
    }
}