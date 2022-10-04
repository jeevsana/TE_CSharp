using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class mobile
    {



        public static void Main()
        {
            number();
        }
        public static void number()
        {
            Console.WriteLine("Mobile Number Validation");
            //condition is the mobile no should start with 7,8,9
            Console.WriteLine("Enter mobile Number which starts with 7,8,9 ");

            // Enter your mobile no

            Console.WriteLine("Enter the 10 digit mobile number");
            var number = Console.ReadLine();
            var validate_number = Regex.IsMatch(number, @"^[987]\d{9}$");// if it statisfy the condition 
            Console.WriteLine(validate_number);//display as true 
        }

    }

}