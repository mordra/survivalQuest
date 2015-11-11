using System.ComponentModel.Design;
using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    public class Animal : IAnimal
    {
        public string Name;
        public AnimalType Type;

        // each is a percentage value; reaching 100 in any results in death
        public int Hunger = 0;      // increases with time - eating food reduces this value
        public int Thirst = 0;      // increases with time - drinking water reduces this value
        public int Fatigue = 0;     // increases with time - sleep or rest reduces this value
        public int Harm = 0;        // increases if physically hurt or wounded - value decreases with time


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
            return "Name: " + Name + ", Type: " + Type + ", Home: " + OptimalShelter() + ", Size " + GetSize() +
                    ", Lifestyle: " + (IsNocturnal() ? "Nocturnal" : "Diurnal") + "\n" +
                    "Hunger: " + Hunger + ", Thirst: " + Thirst + ", Fatigue: " + Fatigue + ", Harm: " + Harm + "\n";
        }
    }
}