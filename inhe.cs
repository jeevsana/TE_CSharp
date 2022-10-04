using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Bonus
    {
        protected int bonus;
    }
    public class Staff : Bonus
    {
        protected int salary = 30900;
        public void GetBonus1()
        {
            bonus = 3 * salary;
            Console.WriteLine($"Staff salary: {salary} and Bonus= {bonus}");
            Console.WriteLine("----------------------------------------------");
        }
    }
    public class NonStaff : Staff
    {
        protected int salary = 15900;
        public void GetBonus2()
        {
            bonus = 2 * salary;
            Console.WriteLine($"Non Staff Salary: {salary} and Bonus= {bonus}");
            Console.WriteLine("----------------------------------------------");
        }
    }
    internal class inher
    {
        class Program
        {
            public static void Main()
            {
                Staff s = new Staff();
                s.GetBonus1();
                NonStaff n = new NonStaff();
                n.GetBonus2();

            }
        }
    }

}