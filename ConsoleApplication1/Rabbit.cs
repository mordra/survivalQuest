using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    class Rabbit : Animal, IMammal
    {
        public Rabbit(string name)
        {
            Name = name;
            Type = AnimalType.Rabbit;

        }

        public override AnimalSize GetSize()
        {
            return AnimalSize.Small;
        }

        public override ShelterType OptimalShelter()
        {
            return ShelterType.Burrow;
        }
    }
}