using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    class Frog : Animal, IAmphibian
    {
        public Frog(string name) : base(name) { }


        public override AnimalType Type => AnimalType.Frog;

        public override AnimalSize GetSize()
        {
            return AnimalSize.Tiny;
        }

        public override ShelterType OptimalShelter()
        {
            return ShelterType.Bush;
        }
    }
}