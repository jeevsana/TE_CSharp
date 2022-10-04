using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Array
    {
        public static void Main()
        {
            Array_2D();
        }
        public static void Array_2D()
        {
            Console.Write("Enter Rows: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Column: ");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row, col];
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    Console.Write("Enter Matrix({0},{1}): ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[,] b = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("Enter Matrix({0},{1}): ", i, j);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[,] result = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
