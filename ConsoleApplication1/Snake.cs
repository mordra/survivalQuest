using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    class Snake : Animal, IReptile
    {
        public Snake(string name) : base(name) { }

        public override AnimalType Type => AnimalType.Snake;

        public override bool IsNocturnal()
        {
            return true;
        }

        public override ShelterType OptimalShelter()
        {
            return ShelterType.Burrow;
        }
    }
}