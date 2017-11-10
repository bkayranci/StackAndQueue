using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class MyQueue
    {
        MyList list;
        public MyQueue()
        {
            this.list = new MyList();
        }

        public void Enqueue(string item)
        {
            this.list.AddLast(new MyItem(item));
        }

        public MyItem Dequeue()
        {
            MyItem temp = this.list.GetFirst();
            this.list.RemoveFront();
            return temp;
        }

        public bool IsEmpty()
        {
            return this.list.IsEmpty();
        }
    }
}
