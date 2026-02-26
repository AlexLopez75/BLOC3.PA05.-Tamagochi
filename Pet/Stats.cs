using System;

namespace BLOC3.PA05.Tamagochi.Pet
{
    public class Stats
    {
        public int Hunger { get; init; }
        public int Energy { get; init; }
        public int Health { get; init; }
        public int Fun { get; init; }

        public Stats(int hunger, int energy, int health, int fun)
        {
            Hunger = hunger;
            Energy = energy;
            Health = health;
            Fun = fun;
        }
    }
}
