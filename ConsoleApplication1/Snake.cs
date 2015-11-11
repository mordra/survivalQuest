using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    class Snake : Animal, IReptile
    {
        public Snake(string name)
        {
            Name = name;
            
        }

        public override bool IsNocturnal()
        {
            return true;
        }
    }
}