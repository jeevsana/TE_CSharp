using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Control_Statement
    {
        public static void Main(string[] args)
        {
            int time = 3;
            if (time < 10)
            {
                Console.WriteLine ("Hello!");
                Console.WriteLine("Welcome to Control Statement.");
                Console.WriteLine("Thank you for visiting");
                Console.WriteLine("--------------------------------------");
             }
            else if(time < 20)
            {
                Console.WriteLine("Regards /n Team");
                Console.WriteLine("-------------------------------------");

            }
            else
            {
                Console.WriteLine("Good evening");
                Console.WriteLine("Team Meeting");
                Console.WriteLine("Starts in 1hr");
                Console.WriteLine("-------------------------------------");

            }
        }

    }
}
