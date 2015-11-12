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
            while (!Console.KeyAvailable)
            {
                foreach (var animal in _animals)
                {
                    animal.DoAction();
                }
                // each animal will take an action - turn based
                // increase fatigue, hunger and thirst for each animal based on the action

            }
        }
    }
}