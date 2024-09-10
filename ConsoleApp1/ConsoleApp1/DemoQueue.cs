using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DemoQueue
    {
        Queue queue = new Queue();
        public DemoQueue() { 
            
        }
        public void set(int value)
        {
            queue.Enqueue(value);
        }
        public void get()
        {
            queue.Dequeue();
        }
    }
}
