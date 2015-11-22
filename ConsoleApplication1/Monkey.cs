using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    class Monkey : Animal, IMammal
    {
        public Monkey(string name) : base(name) { }


        public override AnimalType Type => AnimalType.Monkey;

        public override AnimalSize GetSize()
        {
            return AnimalSize.Medium;
        }

        public override ShelterType OptimalShelter()
        {
            return ShelterType.Tree;
        }
    }
}