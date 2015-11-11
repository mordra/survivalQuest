using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    class Chicken : Animal, IMammal
    {
        public Chicken(string name)
        {
            Name = name;
        }

    }
}