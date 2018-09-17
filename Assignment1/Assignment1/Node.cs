using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Node<T>
    {
        private T item;
        private Node<T> next;

        public Node (T item, Node<T> next)
        {
            this.item = item;
            this.next = next;
        }

        // Read and write properties for each data member
        public T Item
        {
            get { return this.item; }
            set { this.item = value; }
        }

        public Node<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
