using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Menu
    {
        public int id {  get; set; }
        public string title { get; set; }
        public int parent_id { get; set; }

        public Menu(int id, string title, int parent_id)
        {
            this.id = id;
            this.title = title;
            this.parent_id = parent_id;
        }
    }
}
