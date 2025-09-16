using Backpack.Core.Interfaces;

namespace Backpack.Core
{
    public class BackpackHandler : IBackpackHandler
    {
        public void AddItem(Backpack backpack, string itemTitle, byte itemWeight)
        {
            if (itemWeight > (backpack.MaxWeight - backpack.TotalWeight))
            {
                Console.WriteLine("Error! The weight of your item exceeds the capacity of your backpack");
                return;
            }
            else if (itemWeight == 0)
            {
                Console.WriteLine("Error! The weight of your item cannot be zero");
                return;
            }

            backpack.Items.Add(new Item(itemTitle, itemWeight));
            backpack.TotalWeight += itemWeight;

            Console.WriteLine($"Excellent! Item {itemTitle} weighing {itemWeight} is packed in the backpack");
            Console.WriteLine($"Total weight is now: {backpack.TotalWeight}");
        }

        public void GetAllItems(Backpack backpack)
        {
            if (backpack.Items.Count == 0)
            {
                Console.WriteLine($"Error! Your backpack has zero items");
                return;
            }

            byte i = 1;
            Console.WriteLine("In your backpack: ");
            foreach (Item item in backpack.Items)
            {
                Console.WriteLine($"{i}. {item.Title} with weight {item.Weight}");
            }
        }

        public void GetItem(Backpack backpack, string itemTitle)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(Backpack backpack, string itemTitle)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Backpack backpack, string itemTitle, string updItemTitle, byte updItemWeight)
        {
            throw new NotImplementedException();
        }
    }
}
