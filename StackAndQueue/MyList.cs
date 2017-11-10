using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class MyList
    {
        MyItem head;
        MyItem tail;

        public MyList()
        {
            this.head = null;
            this.tail = null;
        }

        public MyItem GetFirst()
        {
            return this.head;
        }

        public MyItem GetLast()
        {
            return this.tail;
        }

        public void AddFront(MyItem item)
        {
            if (head == null)
            {
                this.head = item;
                this.tail = item;
            }
            else
            {
                head.prev = item;
                item.next = head;
                this.head = item;
            }
        }

        public void AddLast(MyItem item)
        {
            if (IsEmpty())
            {
                AddFront(item);
            }
            else
            {
                tail.next = item;
                item.prev = tail;
                tail = item;
            }
        }

        public void AddAfter(MyItem current, MyItem item)
        {
            item.next = current.next;
            item.prev = current;
            item.next.prev = item;
            current.next = item;
        }

        public void AddBefore(MyItem current, MyItem item)
        {
            item.prev = current.prev;
            item.next = current;
            current.prev.next = item;
            current.prev = item;
        }

        public void RemoveLast()
        {
            if (tail == head)
            {
                tail = null;
                head = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
            }
        }

        public void RemoveFront()
        {
            if (head != tail)
            {
                head = head.next;
                head.prev = null;
            } else
            {
                head = tail = null;
            }
        }

        public bool IsEmpty()
        {
            if (this.GetLength() == 0)
            {
                return true;
            }

            return false;
        }

        public int GetLength()
        {
            MyItem current = this.head;

            if (current == null)
            {
                return 0;
            }

            int total = 1;

            while (current != tail)
            {
                current = current.next;
                total++;
            }

            return total;
        }
    }
}
