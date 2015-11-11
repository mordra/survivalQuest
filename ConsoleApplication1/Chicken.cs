using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    class Chicken : Animal, IMammal
    {
        public Chicken(string name)
        {
            Name = name;
            Type = AnimalType.Chicken;

        }

        public override AnimalSize GetSize()
        {
            return AnimalSize.Small;
        }

        public override ShelterType OptimalShelter()
        {
            return ShelterType.Bush;
        }
    }
}