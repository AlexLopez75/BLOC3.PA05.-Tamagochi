using System;

namespace BLOC3.PA05.Tamagochi.Pet.Animal
{
    public abstract class AAnimal : APet
    {
        protected AAnimal(string name, Emotion emotion, Stats stats) : base(name, emotion, stats) { }
    }
}
