using BLOC3.PA05.Tamagochi.Inventory.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLOC3.PA05.Tamagochi.Inventory.Item.Toy
{
    public class Toy : AItem
    {
        public string TName {  get; set; }
        public Toy(string tName, ItemType itemType) : base(tName, itemType)
        {
            TName = tName;
        }

    }
}
