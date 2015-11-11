using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    public class Animal : IAnimal
    {
        public string Name;
        public AnimalType AnimalType;

        public struct DynamicStat
        {
            // each is a percentage value; reaching 100 in any results in death
            public int Hunger;      // increases with time - eating food reduces this value
            public int Thirst;      // increases with time - drinking water reduces this value
            public int Fatigue;     // increases with time - sleep or rest reduces this value
            public int Harm;        // increases if physically hurt or wounded - value decreases with time
        }

        public virtual bool IsNocturnal()
        {
            return false;
        }

        public virtual AnimalSize GetSize()
        {
            return AnimalSize.Medium;
        }

        public virtual ShelterType OptimalShelter()
        {
            return ShelterType.None;
        }

        public string GetTextSummary()
        {
            return "Hi! I am " + Name + " the " + AnimalType + ".\n" +
                    "My preferred shelter is " + OptimalShelter() + " and my size is " + GetSize() + ".\n" +
                    (IsNocturnal() ? "I prefer the night!\n" : "I'm afraid of the dark!\n");
        }
    }
}