using System;
using System.ComponentModel.Design;
using System.Xml;
using ConsoleApplication1.enums;
using ConsoleApplication1.interfaces;

namespace ConsoleApplication1
{
    public abstract class Animal : IAnimal
    {
        public string Name;
        public bool IsSheltered { get; set; }

        // each is a percentage value; reaching 100 in any results in death
        public int Hunger = 0,      // increases with time - eating food reduces this value
                   Thirst = 0,      // increases with time - drinking water reduces this value
                   Fatigue = 0,     // increases with time - sleep or rest reduces this value
                   Harm = 0;        // increases if physically hurt or wounded - value decreases with time

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
            Fatigue = IsSheltered ? Math.Max(0, Fatigue - 10) : Math.Max(0, Fatigue - 5);
        }

        public virtual void FindFood()
        {
            // 40% chance to find food
            if (Dice.D(10) < 4) 
            {
                Hunger = Math.Max(0, Hunger - 10);
            }
            // fail to find food - get hungry
            else
            {
                Hunger += 3;
            }

            Fatigue += 3;
            Thirst += 3;
        }

        public virtual void FindWater()
        {
            throw new NotImplementedException();
        }

        public virtual void FindShelter()
        {
            throw new NotImplementedException();
        }

    }
}