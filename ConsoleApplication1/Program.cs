using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal> {new Owl("Happy"), new Owl("Sad"), new Owl("Grumpy"), new Chicken("BukBuk")};

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.IsNocturnal() ? "Hi {0}, I am nocturnal!" : "Hi {0}, I like the daylight!",
                    animal.Name);
            }

            var nocturnals = animals.Where(x => x.IsNocturnal()).ToList();
            foreach (var nocturnal in nocturnals)
            {
                Console.WriteLine("I'm nocturnal: {0}", nocturnal.Name);
            }

            Console.ReadLine();
        }
    }

}