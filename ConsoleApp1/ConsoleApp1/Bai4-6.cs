using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bai4_6
    {
        public Product findProduct(List<Product> p, string nameProduct)
        {
            Product p1 = new Product();
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].Name.Equals(nameProduct))
                {
                    p1 = p[i];
                }
            }
            return p1;
        }

        public List<Product> findbyCategory(List<Product> p, int categoryID)
        {
            List<Product> p2 = new List<Product>();
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].CategoryID == categoryID)
                {
                    p2.Add(p[i]);
                }
            }
            return p2;

        }
        public List<Product> findbyPrice(List<Product> p, int price)
        {
            List<Product> p2 = new List<Product>();
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].Price <= price)
                {
                    p2.Add(p[i]);
                }
            }
            return p2;

        }
    }
}
