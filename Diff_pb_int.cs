using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Internal
    {
        public string ecourse;
        public void std_details(string course)
        {
            ecourse = course;
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"{ecourse}");
            Console.WriteLine("------------------------------------");
        }
    }
    public class Internal_public
    {
        public static void Main()
        {
            Internal inter = new Internal();
            inter.std_details(".NET STREAM");
        }
    }
}
