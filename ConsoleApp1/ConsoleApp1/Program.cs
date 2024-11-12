using System;
using System.Collections;
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
        private static Bai4_6 Bai4_6 = new Bai4_6();
        private static Bai11_16 Bai11_16 = new Bai11_16();
        private static Bai21_25 Bai21_25 = new Bai21_25();
        static void Main(string[] args)
        {
            /*            // Find Product
                        Console.WriteLine("Find Product by name CPU");
                        Console.WriteLine(Bai4_6.findProduct(products, "CPU").ToString());
                        // Find ProductByCategory
                        Console.WriteLine("Find ProductByCategory id = 2");
                        for (int i = 0; i < Bai4_6.findbyCategory(products, 2).Count; i++)
                        {
                            Console.WriteLine(Bai4_6.findbyCategory(products, 2)[i].ToString());
                        }

                        // Find ProductByPrice
                        Console.WriteLine("Find ProductByPrice < 200");
                        for (int i = 0; i < Bai4_6.findbyPrice(products, 200).Count; i++)
                        {
                            Console.WriteLine(Bai4_6.findbyPrice(products, 200)[i].ToString());
                        }*/

 /*           //11 Buble Sort
            Console.WriteLine("Buble sort");
            for (int i = 0; i < Bai11_16.sortByPrice(products).Count; i++)
            {
                Console.WriteLine(Bai11_16.sortByPrice(products)[i].ToString());
            }

            //12 Insertion Sort
            Console.WriteLine("Insertion sort");
            for (int i = 0; i < Bai11_16.sortByName(products).Count; i++)
            {
                Console.WriteLine(Bai11_16.sortByName(products)[i].ToString());
            }

            //13 Insertion Sort
            Console.WriteLine("Insertion sort");
            List<Category> sortedList = categories.OrderBy(x => x.Name).ToList();
            for (int i = 0; i < Bai11_16.sortByCategoryName(products, sortedList).Count; i++)
            {
                Console.WriteLine(Bai11_16.sortByCategoryName(products, sortedList)[i].ToString());
            }

            //14 mapProductByCategory
            List<Product> products1 = Bai11_16.mapProductByCategory(products, categories);
            for (int i = 0; i < products1.Count; i++)
            {
                Console.WriteLine("Name:" + products1[i].Name + "\tprice:" + products1[i].Price + "\tquality:"
                    + products1[i].Quality + "\tcategoryID:" + products1[i].CategoryID + "\tnameCategory:" + products1[i].CategoryName);
            }



            //15 minByPrice
            Console.WriteLine("MinByPrice");
            Console.WriteLine(Bai11_16.minByPrice(products).ToString());
            //16 maxByPrice
            Console.WriteLine("MaxByPrice");
            Console.WriteLine(Bai11_16.maxByPrice(products).ToString());

            //21 de quy
            Console.Write("Salary:");
            double s = float.Parse(Console.ReadLine());
            Console.Write("Year:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Bai21_25.calSalary(s, n));

            //21 khong de quy
            Console.Write("Salary:");
            double s1 = float.Parse(Console.ReadLine());
            Console.Write("Year:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(Bai21_25.calSalary1(s1, n1));

            //22 de quy
            Console.WriteLine("So thang can gui: " + Bai21_25.calMonth(1000, 0.5f));

            //22 khong de quy
            Console.WriteLine("So thang can gui: " + Bai21_25.calMonth2(1000, 0.5f));*/

            //23 printMenu
            Bai21_25.printMenu(menu);

            //24 Stack
            Stack<Product> stack = new Stack<Product>();
            for(int i = 0; i< products.Count - 2; i++)
            {
                stack.push(products[i]);
            }
            // Top of Stack
            Console.WriteLine("Top of Stack");
            Console.WriteLine(stack.peek().ToString());
            // Pop stack
            Console.WriteLine("Pop stack");
            stack.pop();
            Console.WriteLine(stack.peek().ToString());

            //25 Queue
            Queue<Product> queue = new Queue<Product>();
            for (int i = 0; i < products.Count - 4; i++)
            {
                queue.enqueue(products[i]);
            }
           
            // front element Queue
            Console.WriteLine("front element Queue");
            Console.WriteLine(queue.getFront().ToString());
            // rear element Queue
            Console.WriteLine("rear element Queue");
            Console.WriteLine(queue.getRear().ToString());
            // Dequeue
            queue.dequeue();
            // front dequeue
            Console.WriteLine("front dequeue");
            Console.WriteLine(queue.getFront().ToString());
            // rear dequeue
            Console.WriteLine("rear dequeue");
            Console.WriteLine(queue.getRear().ToString());

        }

    }
}
