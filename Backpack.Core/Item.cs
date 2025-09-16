namespace Backpack.Core
{
    public class Item
    {
        public byte Weight { get; set; }
        public string Title { get; set; }

        public Item(string title, byte weight)
        {
            Title = title;
            Weight = weight;
        }
    }
}
