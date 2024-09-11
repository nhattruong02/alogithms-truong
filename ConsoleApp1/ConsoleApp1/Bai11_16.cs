using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bai11_16
    {
        public Product minByPrice(List<Product> products)
        {
            Product p = new Product();
            p = products[0];
            for (int i = 1; i <= products.Count - 1; i++)
            {
                if (products[i].Price < p.Price)
                {
                    p = products[i];
                }
            }
            return p;
        }

        public Product maxByPrice(List<Product> products)
        {
            Product p = new Product();
            p = products[0];
            for (int i = 1; i <= products.Count - 1; i++)
            {
                if (products[i].Price > p.Price)
                {
                    p = products[i];
                }
            }
            return p;
        }



        public List<Product> sortByPrice(List<Product> p)
        {

            for (int i = 0; i < p.Count; i++)
            {
                for (int j = 0; j < p.Count - 1; j++)
                {
                    if (p[j].Price > p[j + 1].Price)
                    {
                        swap(p, j, j + 1);
                    }
                }
            }
            return p;

        }

        public void swap(List<Product> products, int p1, int p2)
        {
            Product tmp = new Product();
            tmp = products[p1];
            products[p1] = products[p2];
            products[p2] = tmp;
        }

        public List<Product> sortByName(List<Product> p)
        {
            int j;
            Product tmp = new Product();
            for (int i = 1; i < p.Count; i++)
            {
                j = i - 1;
                tmp = p[i];
                while (tmp.Name.Length < p[j].Name.Length && j > 0)
                {
                    p[j + 1] = p[j];
                    j--;
                }
                p[j + 1] = tmp;
            }

            return p;

        }

        public List<Product> sortByCategoryName(List<Product> p, List<Category> c)
        {
            int j;
            Product tmp;
            for (int i = 1; i < p.Count; i++)
            {
                j = i - 1;
                tmp = p[i];
                string name = getCategoryName(tmp.CategoryID, c);
                while (j >= 0)
                {
                    string currentName = getCategoryName(p[j].CategoryID, c);
                    if (string.Compare(currentName, name) <= 0)
                    {
                        break;
                    }
                    p[j + 1] = p[j];
                    j--;
                }
                p[j + 1] = tmp;
            }

            return p;
        }


        public string getCategoryName(int idCategory, List<Category> categories)
        {
            foreach (Category c in categories)
            {
                if (c.Id == idCategory)
                {
                    return c.Name;
                }
            }
            return null;
        }
        public List<Product> mapProductByCategory(List<Product> p, List<Category> c)
        {
            foreach (Product p2 in p)
            {
                foreach (Category c2 in c)
                {
                    if (p2.CategoryID == c2.Id)
                    {
                        p2.CategoryName = c2.Name;
                    }
                }
            }
            return p;
        }
    }
}
