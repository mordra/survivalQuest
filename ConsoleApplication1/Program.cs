using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.enums;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var world = new World();
            world.Populate();
            world.Run();

            Console.ReadLine();
        }
    }
}