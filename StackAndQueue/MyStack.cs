using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class MyStack
    {
        MyList myList;
        public MyStack()
        {
            this.myList = new MyList();
        }

        public void Push(string item)
        {
            this.myList.AddLast(new MyItem(item));
        }

        public MyItem Pop()
        {
            MyItem temp = this.myList.GetLast();
            myList.RemoveLast();
            return temp;
        }

        public bool IsEmpty()
        {
            return this.myList.IsEmpty();
        }
    }
}
