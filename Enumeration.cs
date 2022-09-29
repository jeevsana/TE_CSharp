using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{

    internal class Enumeration
    {

        enum Student
        {
            Sam,
            Demon = 1345,
            Jack = 1052,
            Wakas = 1053,
        }
        public static void Main()
        {
            Console.WriteLine(Student.Sam);
            int methods = (int)Student.Demon;
            Console.WriteLine(methods);
          
            var del = (Student)1053;
            Console.WriteLine(del);
            int id = (int)Student.Jack;
            Console.WriteLine(id);

        }
    }
}
