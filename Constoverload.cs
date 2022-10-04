using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class addition
    {
        public addition(int x,int y)
        {
            Console.WriteLine($"Output in int: {x  + y}");
        }
        public addition(float a, float b)
        {
            Console.WriteLine($"Output in float: {a + b}");
        }
        public addition(string p, string q)
        {
            Console.WriteLine($"Output in string: {p + q}");
        }

    }
    public class subtraction
    {
        public subtraction(int x, int y)
        {
            Console.WriteLine($"Output in int: {x - y}");
        }
        public  subtraction(float a, float b)
        {
            Console.WriteLine($"Output in float: {a - b}");
        }

    }
    internal class constoverload
    {
        public static void Main()
        {
            addition add = new addition(23 , 9);
            addition add1 = new addition(3.98f, 9.098f);
            addition add2 = new addition("Hello!", "This is .NET STREAM");
            Console.WriteLine("-------------------------------------------");

           subtraction sbs = new subtraction(23, 9);
           subtraction sbs1 = new subtraction(3.98f, 9.098f);
        }
    }











}
