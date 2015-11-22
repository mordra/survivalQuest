using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    class Koala : Animal, IMammal
    {
        public Koala(string name) : base(name) { }


        public override AnimalType Type => AnimalType.Koala;

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