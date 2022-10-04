using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Student
    {
        public static void Main()
        {
            int id;
            string name, dept, comp;
            details(out id, out name, out dept, out comp);
            Console.WriteLine($"Student ID={id}");
            Console.WriteLine($"Student NAME={name}");
            Console.WriteLine($"Student DEPARTMENT={dept}");
            Console.WriteLine($"COMPANY={comp}");
        }
       public static void details(out int sid,out string sname,out string  sdept ,out string scomp)
        {
            sid = 12319;
            sname = "Karan";
            sdept = ".NET Stream";
            scomp = "TE_Company";
        }
    }
}
