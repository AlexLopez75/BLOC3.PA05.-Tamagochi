using BLOC3.PA05.Tamagochi.Inventory.Item;
using System;

namespace BLOC3.PA05.Tamagochi.Inventory
{
    public class Inventory
    {
        public int MaxCapacity { get; }
        public AItem Item { get; }
        public Inventory(int maxCapacity, AItem item)
        {
            MaxCapacity = 10;
            Item = item;
        }
    }
}
