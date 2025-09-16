using Backpack.Core;
using System.Runtime.CompilerServices;
using System.Text;

namespace Backpack.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Core.Backpack backpack = new Core.Backpack();
            BackpackHandler handler = new BackpackHandler();

            do
            {
                Console.Clear();
                Logger.Print("=== Backpack App ===");
                Logger.Print("1 - Add new item");
                Logger.Print("2 - Remove item");
                Logger.Print("3 - Get item");
                Logger.Print("4 - Get all items");
                Logger.Print("5 - Update items");
                Logger.Print("Q - Exit application");

                string? userInput = Console.ReadLine();

                if (userInput.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                switch (userInput)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Remove();
                        break;
                    case "3":
                        Get();
                        break;
                    case "4":
                        GetAll();
                        break;
                    case "5":
                        Update();
                        break;
                }
            }
            while (true);

            void Add()
            {
                Console.Clear();
                Logger.Print("=== Add new item mode ===");

                do
                {
                    Logger.Print("Enter title of your item, then with SPACE weight of your item");
                    Logger.Print("If you want to back to main menu, enter Q");

                    string? input = Console.ReadLine();
                    Console.Clear();

                    if (input.Equals("Q", StringComparison.OrdinalIgnoreCase))
                    {
                        return;
                    }

                    string[] parts = input.Split(' ');
                    if (parts.Length < 2 || parts.Length > 2)
                    {
                        Logger.PrintError("Invalid input format. Expected: 'TITLE WEIGHT'");
                        continue;
                    }

                    string title = string.Join(" ", parts.Take(parts.Length - 1));
                    byte weight = byte.Parse(parts.Last());

                    handler.AddItem(backpack, title, weight);
                }
                while (true);
            }

            void Remove()
            {
                Console.Clear();
                Logger.Print("=== Remove item mode ===");

                do
                {
                    Logger.Print("Enter item title you want to remove");
                    Logger.Print("If you want to back to main menu, enter Q");

                    string? input = Console.ReadLine();
                    Console.Clear();

                    if (input.Equals("Q", StringComparison.OrdinalIgnoreCase))
                    {
                        return;
                    }

                    handler.RemoveItem(backpack, input);
                }
                while (true);
            }

            void Get()
            {
                Console.Clear();
                Logger.Print("=== Get item mode ===");

                do
                {
                    Logger.Print("Enter item title you want to get");
                    Logger.Print("If you want to back to main menu, enter Q");

                    string? input = Console.ReadLine();
                    Console.Clear();

                    if (input.Equals("Q", StringComparison.OrdinalIgnoreCase))
                    {
                        return;
                    }

                    handler.GetItem(backpack, input);
                }
                while (true);
            }

            void GetAll()
            {
                Console.Clear();
                Logger.Print("=== Get all items mode ===");

                do
                {
                    handler.GetAllItems(backpack);

                    Logger.Print("If you want to back to main menu, enter Q");

                    string? input = Console.ReadLine();
                    Console.Clear();

                    if (input.Equals("Q", StringComparison.OrdinalIgnoreCase))
                    {
                        return;
                    }
                }
                while (true);
            }

            void Update()
            {
                Console.Clear();
                Logger.Print("=== Update item mode ===");

                do
                {
                    Logger.Print("Enter title of your item, then with SPACE new title and then with SPACE new weight");
                    Logger.Print("If you want to back to main menu, enter Q");

                    string? input = Console.ReadLine();
                    Console.Clear();

                    if (input.Equals("Q", StringComparison.OrdinalIgnoreCase))
                    {
                        return;
                    }

                    string[] parts = input.Split(' ');
                    if (parts.Length < 3 || parts.Length > 3)
                    {
                        Logger.PrintError("Invalid input format. Expected: 'TITLE NEW-TITLE NEW-WEIGHT'");
                        continue;
                    }

                    string itemTitle = parts[0];
                    string itemNewTitle = parts[1];
                    byte itemNewWeight = byte.Parse(parts.Last());

                    handler.UpdateItem(backpack, itemTitle, itemNewTitle, itemNewWeight);
                }
                while (true);
            }
        }
    }
}
