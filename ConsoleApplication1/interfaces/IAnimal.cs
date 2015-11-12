using ConsoleApplication1.enums;

namespace ConsoleApplication1.interfaces
{
    public interface IAnimal
    {
        AnimalType Type { get; }
        bool IsNocturnal();
        AnimalSize GetSize();           // returns general size of animal compared to an average human
        ShelterType OptimalShelter();   // returns favourite shelter type for animal
    }
}