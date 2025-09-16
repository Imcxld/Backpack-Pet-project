using Backpack.Core.Interfaces;

namespace Backpack.Core
{
    public class BackpackHandler : IBackpackHandler
    {
        public void AddItem(Backpack backpack, string itemTitle, byte itemWeight)
        {
            if (itemWeight > (backpack.MaxWeight - backpack.TotalWeight))
            {
                Logger.PrintError("Error! The weight of your item exceeds the capacity of your backpack");
                return;
            }
            else if (itemWeight == 0)
            {
                Logger.PrintError("Error! The weight of your item cannot be zero");
                return;
            }

            backpack.Items.Add(new Item(itemTitle, itemWeight));
            backpack.TotalWeight += itemWeight;

            Logger.PrintSuccess($"Excellent! Item {itemTitle} weighing {itemWeight} is packed in the backpack");
            Logger.Print($"Total weight is now: {backpack.TotalWeight}");
        }

        public void GetAllItems(Backpack backpack)
        {
            if (backpack.Items.Count == 0)
            {
                Logger.PrintError($"Error! Your backpack has zero items");
                return;
            }

            byte i = 1;
            Logger.Print("In your backpack: ");
            foreach (Item item in backpack.Items)
            {
                Logger.Print($"{i}. {item.Title} with weight {item.Weight}");
                i++;
            }
            Logger.Print($"Total weight of backpack: {backpack.TotalWeight}/{backpack.MaxWeight}");
        }

        public void GetItem(Backpack backpack, string itemTitle)
        {
            var item = backpack.Items.FirstOrDefault(i => i.Title == itemTitle);

            if (item != null)
            {
                Logger.Print($"Your item in backpack: {item.Title} with weight {item.Weight}");
            }
            else
            {
                Logger.PrintError("Error! Your backpack does not have this item");
                return;
            }
        }

        public void RemoveItem(Backpack backpack, string itemTitle)
        {
            var item = backpack.Items.FirstOrDefault(i => i.Title == itemTitle);

            if (item != null)
            {
                try
                {
                    backpack.Items.Remove(item);
                }
                catch (Exception ex)
                {
                    Logger.PrintCriticalError(ex.Message);
                }

                Logger.PrintSuccess($"Successfull! Item {item?.Title} has been deleted");
            }
            else
            {
                Logger.PrintError("Error! Your backpack does not have this item");
                return;
            }
        }

        public void UpdateItem(Backpack backpack, string itemTitle, string updItemTitle, byte updItemWeight)
        {
            var item = backpack.Items.FirstOrDefault(i => i.Title == itemTitle);

            if (item != null)
            {
                backpack.TotalWeight -= item.Weight;

                if (updItemWeight > (backpack.MaxWeight - backpack.TotalWeight))
                {
                    Logger.PrintError("Error! The new weight of your item exceeds the capacity of your backpack");
                    backpack.TotalWeight += item.Weight;
                    return;
                }
                else if (updItemWeight == 0)
                {
                    Logger.PrintError("Error! The new weight of your item cannot be zero");
                    backpack.TotalWeight += item.Weight;
                    return;
                }

                var oldTitle = item.Title;
                var oldWeight = item.Weight;

                item.Title = updItemTitle;
                item.Weight = updItemWeight;

                backpack.TotalWeight += item.Weight;

                Logger.PrintSuccess($"Successfull! You have updated item: title({oldTitle}) => {item.Title}, weight ({oldWeight}) => {item.Weight}");
            }
        }
    }
}
