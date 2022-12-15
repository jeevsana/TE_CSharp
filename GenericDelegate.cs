using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class GenericDelegate
    {
        // Declare Generic Delegate
        public delegate T SampleDelegate<T>(T a, T b);
        class MathOperations
        {
            public int Area(int a, int b)
            {
                return a * b;
            }
          
            public double Area(double x, double y)
            {
                return x * y;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("****Generic Delegate Example****");
                MathOperations m = new MathOperations();
                // Instantiate delegate with add method using int
                SampleDelegate<int> dlgt = new SampleDelegate<int>(m.Area);
                Console.WriteLine("Area of circle Result for int: " + dlgt(10, 90));
                // Instantiate delegate with subtract method
                dlgt = m.Area;
               // Console.WriteLine("Area of circle Result for int: " + dlgt(10, 90));

                // Instantiate delegate with add method using double
                SampleDelegate<double> dlgt1 = new SampleDelegate<double>(m.Area);
                Console.WriteLine("Area of circle Result for double: " + dlgt1(10.5, 90.10));
                // Instantiate delegate with subtract method
                dlgt1 = m.Area;
               // Console.WriteLine("Area of circle Result for double: " + dlgt1(10.2, 90.1));
                Console.ReadLine();
            }
        }
    }
}
