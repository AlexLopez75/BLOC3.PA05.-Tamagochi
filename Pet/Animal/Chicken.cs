using System;

namespace BLOC3.PA05.Tamagochi.Pet.Animal
{
    public class Chicken : AAnimal
    {
        protected override string Name { get; init; }

        public Chicken(string name, Emotion emotion, Stats stats) : base(name, emotion, stats)
        {
            Name = name;
        }
    }
}
