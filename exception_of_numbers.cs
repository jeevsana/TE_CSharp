using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class exception_of_numbers
    {
        static void Main(string[] args)
        {
            float Num1, Num2, Result;
            try
            {
                Console.WriteLine("Enter First Number:");
                Num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number:");
                Num2 = float.Parse(Console.ReadLine());
                Result = Num1 / Num2;
                Console.WriteLine($"Result: {Result}");
            }
            catch (DivideByZeroException DBZE)
            {
                Console.WriteLine("Second Number Should Not Be Zero");
            }
            catch (FormatException FE)
            {
                Console.WriteLine("Enter Only Integer Number");
            }
            Console.ReadKey();
        }
    }
}
