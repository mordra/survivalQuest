using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    class Hawk : Animal, IBird
    {
        public Hawk(string name) : base(name) { }


        public override AnimalType Type => AnimalType.Hawk;

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