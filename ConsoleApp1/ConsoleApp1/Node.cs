using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T newData)
        {
            this.data = newData;
            this.next = null;
        }
    }
}
