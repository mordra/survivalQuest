using System;
using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    public abstract class Animal : IAnimal
    {
        public string Name;
        public bool IsSheltered { get; set; }

        // each is a percentage value; reaching 100 in any results in death
        public int Hunger,      // increases with time - eating food reduces this value
                   Thirst,      // increases with time - drinking water reduces this value
                   Fatigue,     // increases with time - sleep or rest reduces this value
                   Harm = 0;    // increases if physically hurt or wounded - value decreases with time

        public abstract AnimalType Type { get; }

        protected Animal(string name)
        {
            Name = name;
            IsSheltered = false;
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

        public override string ToString()
        {
            return string.Format("Name: {0}, Type: {1},  Home: {2}, Size {3}, Lifestyle: {4}{9}Hunger: {5}, Thirst: {6}, Fatigue: {7}, Harm: {8}{9}", 
                                  Name, Type, OptimalShelter(), GetSize(), IsNocturnal()? "Nocturnal":"Diurnal", Hunger, Thirst, Fatigue, Harm, Environment.NewLine);
        }

        public void DoAction()
        {
            // increase hunger, thirst and fatigue due to passage of time 
            DepleteEnergy(2,2,3);

            switch (Dice.D(4))
            {
                case 1:     // look for shelter
                    FindShelter();
                    break;
                case 2:     // look for food
                    FindFood();
                    break;
                case 3:     // look for water
                    FindWater();
                    break;
                case 4:     // rest
                    Rest();
                    break;
                default:
                    // do nothing - should never be executed
                    throw new Exception();
            }
        }

        public virtual void Rest()
        {
            Fatigue = IsSheltered ? Math.Max(0, Fatigue - 20) : Math.Max(0, Fatigue - 8);
        }

        public virtual void FindFood()
        {
            // 40% chance to find food
            if (Dice.D(10) < 4) 
            {
                Hunger = Math.Max(0, Hunger - 15);
            }
        }

        public virtual void FindWater()
        {
            // 10% chance to find lots of water, 60% to find small amount
            int rand = Dice.D(10);
            if (rand == 1)
            {
                Thirst = 0;         // fully quenched
            }
            else if (rand < 8)
            {
                Thirst = Math.Max(0, Thirst - 15);
            }

        }

        public virtual void FindShelter()
        {
            // If animal already has shelter, simply return to it and rest
            if (IsSheltered)
            {
                Rest();
                return;
            }
            // 10% chance to find optimal shelter
            if (Dice.D(10) == 1)
            {
                IsSheltered = true;
            }
        }

        public virtual void DepleteEnergy(int hunger, int thirst, int fatigue)
        {
            Hunger = Math.Min(100, Hunger + hunger);
            Thirst = Math.Min(100, Thirst + thirst);
            Fatigue = Math.Min(100, Fatigue + fatigue);
        }

    }
}