using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bai4_6
    {
        /// <summary>
        /// Find Product by name
        /// </summary>
        /// <param name="p"></param>
        /// <param name="nameProduct"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Find product by category
        /// </summary>
        /// <param name="p"></param>
        /// <param name="categoryID"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Find product by price
        /// </summary>
        /// <param name="p"></param>
        /// <param name="price"></param>
        /// <returns></returns>
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
