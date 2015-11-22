using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    class Bear : Animal, IMammal
    {
        public Bear(string name) : base(name) { }


        public override AnimalType Type => AnimalType.Bear;

        public override AnimalSize GetSize()
        {
            return AnimalSize.Large;
        }

        public override ShelterType OptimalShelter()
        {
            return ShelterType.Cave;
        }
    }
}