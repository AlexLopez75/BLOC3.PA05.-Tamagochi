using System;

namespace BLOC3.PA05.Tamagochi.Pet
{
    public class Stats
    {
        public int Hunger { get; set; }
        public int Energy { get; set; }
        public int Health { get; set; }
        public int Fun { get; set; }

        public Stats()
        {
            Hunger = 100;
            Energy = 100;
            Health = 100;
            Fun = 100;
        }
    }
}
