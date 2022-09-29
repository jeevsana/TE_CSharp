using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Static_Instance
    {
        public int multiplication(int a, int b)
        {
            int val = a * b;
            return val;
        }
        static void Main(string[] args)
        {
            Static_Instance a = new Static_Instance();
            int newval = a.multiplication(12, 12);
            Console.WriteLine(newval);
            Console.WriteLine("-------------------------------");
            Console.ReadKey();
        }
    }
}