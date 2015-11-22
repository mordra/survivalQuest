using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    class Camel : Animal, IMammal
    {
        public Camel(string name) : base(name) { }


        public override AnimalType Type => AnimalType.Camel;

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