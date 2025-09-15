using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backpack.Core.Interfaces
{
    public interface IBackpackHandler
    {
        void AddItem(Backpack backpack, string itemTitle, byte itemWeight);

        void RemoveItem(Backpack backpack, string itemTitle);

        void GetItem(Backpack backpack, string itemTitle);

        void GetAllItems(Backpack backpack);

        void UpdateItem(Backpack backpack, string itemTitle, string updItemTitle, byte updItemWeight);
    }
}
