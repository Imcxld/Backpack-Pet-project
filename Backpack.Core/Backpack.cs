using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backpack.Core
{
    public class Backpack
    {
        public List<Item> Items { get; set; } = new List<Item>();

        public byte TotalWeight { get; set; } = 0;

        public byte MaxWeight { get; } = 20;
    }
}
