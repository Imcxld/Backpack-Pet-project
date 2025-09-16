using Backpack.Core;

namespace Backpack.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Core.Backpack backpack = new Core.Backpack();
            BackpackHandler handler = new BackpackHandler();

            handler.AddItem(backpack, "laptop", 10);
            handler.GetAllItems(backpack);
            handler.GetItem(backpack, "laptop");
            handler.RemoveItem(backpack, "laptop");
            handler.GetItem(backpack, "laptop");
        }
    }
}
