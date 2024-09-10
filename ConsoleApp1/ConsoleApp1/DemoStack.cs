using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DemoStack
    {
        Stack stack = new Stack();
        public DemoStack()
        {

        }
        public void set(int value)
        {
            stack.Push(value);
        }
        public void get()
        {
            stack.Pop();
        }

    }
}
