using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    class Giraffe : Animal, IMammal
    {
        public Giraffe(string name) : base(name) { }


        public override AnimalType Type => AnimalType.Giraffe;

        public override AnimalSize GetSize()
        {
            return AnimalSize.Large;
        }

        public override ShelterType OptimalShelter()
        {
            return ShelterType.Bush;
        }
    }
}