using System;

namespace ConsoleApp1
{
    public class Program
    {
/*        public Product tmp = new Product();
*/        private static List<Product> products = new List<Product>
        { new Product(name: "CPU", price: 750, quality: 10, categoryID: 1),
          new Product(name: "RAM", price: 50, quality: 2, categoryID: 2),
          new Product(name: "HDD", price: 70, quality: 1, categoryID: 2),
          new Product(name: "Main", price: 400, quality: 3, categoryID: 1),
          new Product(name: "Keyboard", price: 30, quality: 8, categoryID: 4),
          new Product(name: "Mouse", price: 25, quality: 50, categoryID: 4),
          new Product(name: "VGA", price: 60, quality: 35, categoryID: 3),
          new Product(name: "Monitor", price: 120, quality: 28, categoryID: 2),
          new Product(name: "Case", price: 120, quality: 28, categoryID: 5),
        };
        private static List<Category> categories = new List<Category>
        { new Category(id: 1, name: "CPU"),
          new Category(id: 2, "RAM"),
          new Category(id: 3,name: "HDD"),
          new Category(id: 4,name: "Main"),

        };

        private static List<Menu> menu = new List<Menu>
        {
            new Menu(id: 1, title: "Thể thao", 0),
            new Menu(id: 2, title: "Xã hội", 0),
            new Menu(id: 3, title: "Thể thao trong nước", 0),
            new Menu(id: 4, title: "Giao thông", 0),
            new Menu(id: 5, title: "Môi trường", 0),
            new Menu(id: 6, title: "Thể thao quốc tế", 0),
            new Menu(id: 7, title: "Môi trường đô thị", 0),
            new Menu(id: 8, title: "Giao thông ùn tắc", 0),
        };
        static void Main(string[] args)
        {
            // Find Product
            Console.WriteLine("Find Product by name CPU");
            Console.WriteLine(findProduct(products, "CPU").ToString());
            // Find ProductByCategory
            Console.WriteLine("Find ProductByCategory id = 2");
            for (int i = 0; i < findbyCategory(products, 2).Count; i++)
            {
                Console.WriteLine(findbyCategory(products, 2)[i].ToString());
            }
            // Find ProductByPrice
            Console.WriteLine("Find ProductByPrice < 200");
            for (int i = 0; i < findbyPrice(products, 200).Count; i++)
            {
                Console.WriteLine(findbyPrice(products, 200)[i].ToString());
            }
            //11 Buble Sort
            Console.WriteLine("Buble sort");
            for (int i = 0; i < sortByPrice(products).Count; i++)
            {
                Console.WriteLine(sortByPrice(products)[i].ToString());
            }
            //12 Insertion Sort
/*            Console.WriteLine("Insertion sort");
            for (int i = 0; i < sortByName(products).Count; i++)
            {
                Console.WriteLine(sortByName(products)[i].ToString());
            }*/

            //13 Insertion Sort
            /*            Console.WriteLine("Insertion sort");
                        for (int i = 0; i < sortByCategoryName(products, categories).Count; i++)
                        {
                            Console.WriteLine(sortByCategoryName(products, categories));
                        }*/

            //14 mapProductByCategory
            /*            Console.WriteLine("c short");
                        categories.Sort();
                        for (int i = 0; i < categories.Sort(; i++)
                        {
                            Console.WriteLine(sortByCategoryName(products, categories));
                        }*/

            //15 minByPrice
            Console.WriteLine("MinByPrice");
            Console.WriteLine(minByPrice(products).ToString());
            //16 maxByPrice
            Console.WriteLine("MaxByPrice");
            Console.WriteLine(maxByPrice(products).ToString());

            //21 de quy
/*            Console.WriteLine("Salary:");
            double s = float.Parse(Console.ReadLine());
            Console.WriteLine("Year:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(calSalary(s, n));*/

            //21 khong de quy
            Console.Write("Salary:");
            double s1 = float.Parse(Console.ReadLine());
            Console.Write("Year:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(calSalary1(s1, n1));
        }

/*        private static double calSalary(double salary, int n)
        {
            double sumSalary = 0;
            if (n == 0)
                return sumSalary;
            return 
        }*/

        private static double calSalary1(double salary, int n)
        {
            double sumSalary = 0;
            for (int i = 1; i <= n; i++)
            {
                sumSalary = salary + (salary * 0.1);
            }
            return sumSalary;
        }

        private static Product minByPrice(List<Product> products)
        {
            Product p = new Product();
            p = products[0];
            for (int i = 1; i <= products.Count -1 ; i++) 
            { 
                if (products[i].Price < p.Price)
                {
                    p = products[i];
                }
            }
            return p;
        }

        private static Product maxByPrice(List<Product> products)
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

        private static Product findProduct(List<Product> p, string nameProduct)
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

        private static List<Product> findbyCategory(List<Product> p, int categoryID)
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
        private static List<Product> findbyPrice(List<Product> p, int price)
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

        private static List<Product> sortByPrice(List<Product> p)
        {

            for (int i = 0; i < p.Count; i++)
            {
                for (int j = 0; j < p.Count - 1; j++)
                {
                    if (p[j].Price > p[j + 1].Price)
                    {
                        swap(p,j, j +1 );
                    }
                }
            }
            return p;

        }

        private static void swap(List<Product> products, int p1, int p2)
        {
            Product tmp = new Product();
            tmp = products[p1];
            products[p1] = products[p2];
            products[p2] = tmp;
        }

        private static List<Product> sortByName(List<Product> p)
        {
            int j;
            Product tmp = new Product();
            for (int i = 1; i < p.Count; i++)
            {
                j = i - 1;
                tmp = p[i];
                while (tmp.Name.Length < p[j].Name.Length && j > 0)
                {
                    p[j+1] = p[j];
                    j--;
                }
                p[j + 1] = tmp;
            }

            return p;

        }

/*        private static List<Product> sortByCategoryName(List<Product> p, List<Category> c)
        {
            int j;
            Product tmp = new Product();
            
            for(int a = 0; a < c.Count; a ++)
            for (int i = 1; i < p.Count; i++)
            {
                j = i - 1;
                tmp = p[i];
                while (p[i].CategoryID == c[j].Id && j > 0)
                {
                    p[j + 1] = p[j];
                    j--;
                }
                p[j + 1] = tmp;
            }

            return p;
        }*/


        private static List<Product> mapProductByCategory(List<Product> p, List<Category> c)
        {
            int j;
            Product tmp = new Product();
            c.Sort();
            for (int i = 1; i < p.Count; i++)
            {
                j = i - 1;
                tmp = p[i];
                while (tmp.Name.Length < p[j].Name.Length && j > 0 && c[i].Id == p[i].CategoryID)
                {
                    p[j + 1] = p[j];
                    j--;
                }
                p[j + 1] = tmp;
            }

            return p;
        }
    }
}
