using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    class Buffalo : Animal, IMammal
    {
        public Buffalo(string name) : base(name) { }


        public override AnimalType Type => AnimalType.Buffalo;

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