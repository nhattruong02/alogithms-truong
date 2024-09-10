using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace ConsoleApp1
{
    public class Program
    {
        private static Product product = new Product();
        private static List<Product> products = new List<Product>
        {
          new Product(name: "CPU", price: 750, quality: 10, categoryID: 1),
          new Product(name: "RAM", price: 50, quality: 2, categoryID: 2),
          new Product(name: "HDD", price: 70, quality: 1, categoryID: 2),
          new Product(name: "Main", price: 400, quality: 3, categoryID: 1),
          new Product(name: "Keyboard", price: 30, quality: 8, categoryID: 4),
          new Product(name: "Mouse", price: 25, quality: 50, categoryID: 4),
          new Product(name: "VGA", price: 60, quality: 35, categoryID: 3),
          new Product(name: "Monitor", price: 120, quality: 28, categoryID: 2),
        };
        private static List<Category> categories = new List<Category>
        {
          new Category(id: 1, name: "Computer"),
          new Category(id: 2, name: "Memory"),
          new Category(id: 3,name: "Card"),
          new Category(id: 4,name: "Acsesory"),

        };

        private static List<Menu> menu = new List<Menu>
        {
            new Menu(id: 1, title: "The thao", 0),
            new Menu(id: 2, title: "Xa hoi", 0),
            new Menu(id: 3, title: "The thao trong nuoc", 1),
            new Menu(id: 4, title: "Giao thong", 2),
            new Menu(id: 5, title: "Moi truong", 2),
            new Menu(id: 6, title: "The thao quoc te", 1),
            new Menu(id: 7, title: "Moi truong đo thi", 5),
            new Menu(id: 8, title: "Giao thông un tac", 4),
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
            /*            Console.WriteLine("Buble sort");
                        for (int i = 0; i < sortByPrice(products).Count; i++)
                        {
                            Console.WriteLine(sortByPrice(products)[i].ToString());
                        }*/

            //12 Insertion Sort
            /*            Console.WriteLine("Insertion sort");
                        for (int i = 0; i < sortByName(products).Count; i++)
                        {
                            Console.WriteLine(sortByName(products)[i].ToString());
                        }*/

            //13 Insertion Sort
            /*            Console.WriteLine("Insertion sort");
                        List<Category> sortedList = categories.OrderBy(x => x.Name).ToList();
                        for (int i = 0; i < sortByCategoryName(products, sortedList).Count; i++)
                        {
                            Console.WriteLine(sortByCategoryName(products, sortedList)[i].ToString());
                        }*/

            //14 mapProductByCategory
            List<Product> products1 = mapProductByCategory(products, categories);
            for (int i = 0; i < products1.Count; i++)
            {
                Console.WriteLine("Name:" + products1[i].Name + "\tprice:" + products1[i].Price + "\tquality:"
                    + products1[i].Quality + "\tcategoryID:" + products1[i].CategoryID + "\tnameCategory:" + products1[i].CategoryName);
            }

            /*

            /*            //15 minByPrice
                        Console.WriteLine("MinByPrice");
                        Console.WriteLine(minByPrice(products).ToString());
                        //16 maxByPrice
                        Console.WriteLine("MaxByPrice");
                        Console.WriteLine(maxByPrice(products).ToString());*/

            //21 de quy
            /*            Console.Write("Salary:");
                        double s = float.Parse(Console.ReadLine());
                        Console.Write("Year:");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine(calSalary(s, n));*/

            //21 khong de quy
            /*            Console.Write("Salary:");
                        double s1 = float.Parse(Console.ReadLine());
                        Console.Write("Year:");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(calSalary1(s1, n1));*/

            /*            //22 de quy
                        Console.WriteLine("So thang can gui: " + calMonth(1000, 0.5f));

                        //22 khong de quy
                        Console.WriteLine("So thang can gui: " + calMonth2(1000, 0.5f));*/

            //23 printMenu
            printMenu(menu);
        }

        private static void printMenu(List<Menu> menus)
        {
            List<Menu> parent = new List<Menu>();
            for (int i = 0; i < menus.Count; i++)
            {
                if (menu[i].parent_id == 0)
                {
                    parent.Add(menu[i]);
                }
            }
            foreach (Menu menu in parent)
            {
                foreach(Menu item in menus)
                {
                    Console.WriteLine(menu.title);
                    if (menu.title.Contains(item.title))
                    {
                        Console.WriteLine(draw(item.parent_id) + item.title);
                    }
                }

            }

        }

        public static string draw(int number)
        {
            string dash = "";
            for(int i = 0; i< number; i++) {
                dash += "--";
            }
            return dash;
        }

        private static int calMonth(double money, float rate)
        {
            int month = 0;
            month = int.Parse(calMonth1(money, rate, month).ToString());
            return month;
        }
        private static bool change = true;
        private static double firstMoney;
        private static double calMonth1(double money, float rate, int month)
        {
            if (change)
                firstMoney = money;
            if (money >= 2 * firstMoney)
                return month;
            month++;
            change = false;
            return calMonth1(money + money * rate, rate, month);
        }

        private static int calMonth2(double money, float rate)
        {
            int month = 0;
            double firstMoney = money;
            double sum = 0;
            while (sum <= (2 * firstMoney))
            {
                month++;
                sum = money + (money * rate);
                money = sum;
            }
            return month;
        }


        private static double calSalary(double salary, int n)
        {
            if (n == 1)
                return salary;
            salary = calSalary(salary, n - 1) + calSalary(salary, n - 1) * 0.1;
            return salary;
        }

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
            for (int i = 1; i <= products.Count - 1; i++)
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
                        swap(p, j, j + 1);
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
                    p[j + 1] = p[j];
                    j--;
                }
                p[j + 1] = tmp;
            }

            return p;

        }

        private static List<Product> sortByCategoryName(List<Product> p, List<Category> c)
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
                    string currentName = getCategoryName(products[j].CategoryID, c);
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


        private static string getCategoryName(int idCategory, List<Category> categories)
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

        private static List<Product> mapProductByCategory(List<Product> p, List<Category> c)
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
