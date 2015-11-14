using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class World
    {
        List<Animal> _animals;

        public void Populate()
        {
            _animals = new List<Animal> { new Rabbit("Happy"), new Snake("Sad"), new Owl("Grumpy"), new Chicken("BukBuk") };
        }

        public void Run()
        {
            Console.WriteLine("Press ESC to stop");
            do
            {
                while (!Console.KeyAvailable)
                {
                    // each animal will take an action - turn based
                    // output action and outcome for each animal

                    foreach (var animal in _animals)
                    {
                        animal.DoAction();
                        Console.WriteLine(animal);
                    }
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            Console.WriteLine("Out of the infinite loop now. Press <any> key to exit.");
            Console.ReadLine();

        }
    }
}