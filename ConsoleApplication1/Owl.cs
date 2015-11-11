using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    class Owl : Animal, IBird 
    {
        public Owl(string name)
        {
            Name = name;
            Type = AnimalType.Owl;

        }

        public override bool IsNocturnal()
        {
            return true;
        }

        public override AnimalSize GetSize()
        {
            return AnimalSize.Small;
        }

        public override ShelterType OptimalShelter()
        {
            return ShelterType.Tree;
        }
    }
}