using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class MyItem
    {
        public MyItem next = null;
        public MyItem prev = null;
        public string item;

        public MyItem()
        {
            
        }
        public MyItem(string item)
        {
            this.item = item;
        }


    }
}
