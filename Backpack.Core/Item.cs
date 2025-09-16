namespace Backpack.Core
{
    public class Item
    {
        public byte Weight { get; private set; }
        public string Title { get; private set; }

        public Item(string title, byte weight)
        {
            Title = title;
            Weight = weight;
        }
    }
}
