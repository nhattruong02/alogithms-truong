using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bai21_25
    {
        public void printMenu(List<Menu> menus)
        {
            foreach (Menu m in menus)
            {
                if (m.parent_id == 0)
                {
                    printChildMenu(m, menus, 0);
                }

            }

        }

        public void printChildMenu(Menu m, List<Menu> menus, int level)
        {
            Console.WriteLine(new string('-', level * 2) + m.title);
            foreach (Menu childItem in menus)
            {
                if (childItem.parent_id == m.id)
                {
                    printChildMenu(childItem, menus, level + 1);
                }
            }
        }

        public string draw(int number)
        {
            string dash = "";
            for (int i = 0; i < number; i++)
            {
                dash += "--";
            }
            return dash;
        }

        public int calMonth(double money, float rate)
        {
            int month = 0;
            month = int.Parse(calMonth1(money, rate, month).ToString());
            return month;
        }
        private static bool change = true;
        public static double firstMoney;
        public static double calMonth1(double money, float rate, int month)
        {
            if (change)
                firstMoney = money;
            if (money >= 2 * firstMoney)
                return month;
            month++;
            change = false;
            return calMonth1(money + money * rate, rate, month);
        }

        public static int calMonth2(double money, float rate)
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


        public static double calSalary(double salary, int n)
        {
            if (n == 1)
                return salary;
            salary = calSalary(salary, n - 1) + calSalary(salary, n - 1) * 0.1;
            return salary;
        }

        public static double calSalary1(double salary, int n)
        {
            double sumSalary = 0;
            for (int i = 1; i <= n; i++)
            {
                sumSalary = salary + (salary * 0.1);
            }
            return sumSalary;
        }
    }
}
