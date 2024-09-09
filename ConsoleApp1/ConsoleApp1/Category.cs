using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Category
    {
        private int id { get; set; }
        private string name { get; set; }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
