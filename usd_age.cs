using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class usd_age
    {
        public class AgeException : Exception
        {
            public AgeException(String message) : base(message)
            {

            }
        }
        public class TesttUserDefinedException
        {
            static void validate(int age)
            {
                if(age < 22)
                {
                    throw new AgeException("Oopsss!!!! --- Your  age must be atleast 22 years old To Vote --- \n");
                }
                else
                {
                    Console.WriteLine("YES HURRAH!! ---- YOUR AGE IS ELIGIBLE TO VOTE!!!!----");
                }
            }
            public static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("Enter your age:");
                    var age = Convert.ToInt32(Console.ReadLine());
                    validate(age);
                }
                catch (AgeException e)
                {
                    Console.WriteLine(e);
                }
            }
        }
            
    }
}
