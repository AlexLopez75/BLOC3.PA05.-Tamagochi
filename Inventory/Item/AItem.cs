using System;

namespace BLOC3.PA05.Tamagochi.Inventory.Item
{
    public abstract class AItem
    {
        protected string Name { get; set; }
        protected ItemType Type { get; set; }

        public AItem(string name, ItemType itemType)
        {
            Name = name;
            Type = itemType;
        }
    }
}
