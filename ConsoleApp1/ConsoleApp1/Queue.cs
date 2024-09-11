using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Queue<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public void Set(T value)
        {
            list.AddLast(value);
        }
        public T Get(T value)
        {
            return list.Last.Value;
        }
    }
}
