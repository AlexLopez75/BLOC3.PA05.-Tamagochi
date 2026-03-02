using System;

namespace BLOC3.PA05.Tamagochi.Item.Food
{
    public class Food : AItem
    {
        public string FName { get; set; }
        public FoodType FType { get; set; }
        public Food(string fName, ItemType itemType, FoodType foodType) : base(fName, itemType)
        {
            FName = fName;
            FType = foodType;
        }
    }
}
