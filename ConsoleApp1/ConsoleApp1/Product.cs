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
        private string categoryName;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Quality { get => quality; set => quality = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }

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

        public Product(string name, int price, int quality, int categoryID, string categoryName)
        {
            this.Name = name;
            this.Price = price;
            this.Quality = quality;
            this.CategoryID = categoryID;
            this.CategoryName = categoryName;
        }

        public override string ToString()
        {
            return "Name:" + this.Name + "\tprice:" + this.Price + "\tquality:" + this.Quality + "\tcategoryID:" + CategoryID;
        }
    }
}
