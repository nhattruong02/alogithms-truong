using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Queue<T>
    {
        Node<T> front, rear;
        public Queue(){
            front = rear = null;
        }
        public bool isEmpty()
        {
            return front == null && rear == null;
        }
        public void enqueue(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            if (rear == null)
            {
                front = rear = new_node;
                return;
            }
            rear.next = new_node;
            rear = new_node;
        }

        public void dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue Underflow");
                return;
            }
            front = front.next;
            if (front == null)
            {
                rear = null;
            }
        }

        public T getFront()
        {

            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }
            return front.data;
        }

        public T getRear()
        {
            // Checking if the queue is empty
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }
            return rear.data;
        }
    }
}
