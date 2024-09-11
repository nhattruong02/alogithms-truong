using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bai21_25
    {
        /// <summary>
        /// Print menu level
        /// </summary>
        /// <param name="menus"> list menu</param>
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

        /// <summary>
        /// Using recursion to calculate interest monthly
        /// </summary>
        /// <param name="money"></param>
        /// <param name="rate"></param>
        /// <returns>number of month</returns>
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

        /// <summary>
        /// Calculate interest monthly
        /// </summary>
        /// <param name="money"></param>
        /// <param name="rate"></param>
        /// <returns>number of month</returns>
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


        /// <summary>
        /// Using recursion to calculate salary year by year
        /// </summary>
        /// <param name="salary"></param>
        /// <param name="n"> year</param>
        /// <returns></returns>
        public static double calSalary(double salary, int n)
        {
            if (n == 1)
                return salary;
            return calSalary(salary + salary * 0.1, n - 1);
        }

        /// <summary>
        /// Calculate salary year by year
        /// </summary>
        /// <param name="salary"></param>
        /// <param name="n"> year</param>
        /// <returns></returns>
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
