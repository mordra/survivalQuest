using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    class Rabbit : Animal, IMammal
    {
        public Rabbit(string name)
        {
            Name = name;
        }
    }
}