using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public class Stack<T>
    {
        private Node<T> head;

        public Stack()
        {
            this.head = null;
        }
        public bool isEmpty()
        {
            return head == null;
        }
        public void push(T newData)
        {
            Node<T> new_node = new Node<T>(newData);
            if(new_node == null)
            {
                return;
            }
            new_node.next = head;
            head = new_node;
        }

        public void pop() { 
            if(this.isEmpty())
            {
                
            }
            else
            {
                head = head.next;
            }
        }
        public T peek()
        {
            if (!isEmpty())
                return head.data;
            else
            {
                Console.WriteLine("\nStack is empty");
                return default(T);
            }
        }
    }
}
