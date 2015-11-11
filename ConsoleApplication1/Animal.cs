using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    public class Animal : IAnimal
    {
        public string Name;

        public struct DynamicStat
        {
            // each is a percentage value; reaching 100 in any results in death
            public int Hunger;      // increases with time - eating food reduces this value
            public int Thirst;      // increases with time - drinking water reduces this value
            public int Fatigue;     // increases with time - sleep or rest reduces this value
            public int Harm;        // increases if physically hurt or wounded - value decreases with time
        }

        public struct CoreStat
        {
            public AnimalSize Size;         // impacts strength and metabolic rate
            public ShelterType Shelter;     // preferred type of shelter for optimal rest
        }

        public virtual bool IsNocturnal()
        {
            return false;
        }
    }
}