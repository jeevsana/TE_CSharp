using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employess:");
            string val = Console.ReadLine();
            int n = Convert.ToInt32(val);
            //to store all employees id
            String[] empid = new String[n];
            //to store all employees name
            String[] empname = new String[n];
            //to store all employees number
            String[] empnumber = new String[n];
            //To read employee details
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Employee " + (i + 1) + " ID");
                empid[i] = Console.ReadLine();
                Console.WriteLine("Enter Employee " + (i + 1) + "Name");
                empname[i] = Console.ReadLine();
                Console.WriteLine("Enter Employee " + (i + 1) + "Number");
                empnumber[i] = Console.ReadLine();
            }
            //To dispaly the employee deatils
            Console.WriteLine("Employee Details are");
            //Console.WriteLine("-----------------------");
            Console.WriteLine("ID\t Name");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(empid[i] + "\t" + empname[i] + "\t" + empnumber[i]);
            }
        }
    }
}
