using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Weighted_Chance_App
{
    public class Item
    {
        

        public string item { get; private set; }
        public Bitmap resource { get; private set; }
        public Item(string _item, Bitmap _resource)
        {
            item = _item;
            resource = _resource;
        }
    }
}
