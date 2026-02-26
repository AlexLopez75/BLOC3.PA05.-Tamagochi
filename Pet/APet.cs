using System;

namespace BLOC3.PA05.Tamagochi.Pet
{
    public abstract class APet
    {
        protected abstract string Name { get; set; }
        protected Emotion Emotion { get; set; }
        protected Stats Stats { get; }

        public APet(string name, Emotion emotion, Stats stats) 
        {
            Name = name;
            Emotion = emotion;
            Stats = stats;
        }
    }
}
