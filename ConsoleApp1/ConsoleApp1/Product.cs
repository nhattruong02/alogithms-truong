using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        private string name;
        private int price;
        private int quality;
        private int categoryID;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Quality { get => quality; set => quality = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }

        public Product()
        {
        }

        public Product(string name, int price, int quality, int categoryID)
        {
            this.Name = name;
            this.Price = price;
            this.Quality = quality;
            this.CategoryID = categoryID;
        }

        

        public override string ToString()
        {
            return "Name:" + this.Name + "\tprice:" + this.Price + "\tquality:" + this.Quality + "\tcategoryID:" + CategoryID;
        }
    }
}
