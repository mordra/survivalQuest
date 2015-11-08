namespace ConsoleApplication1
{
    class Owl : Animal, IBird 
    {
        public Owl(string name)
        {
            Name = name;
        }

        public override bool IsNocturnal()
        {
            return true;
        }
    }
}