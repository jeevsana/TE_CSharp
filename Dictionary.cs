using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Dictionary
    {
        public static void Main()
        {
            Dictionary<string, string> My_dic = new Dictionary<string, string>();
            My_dic.Add("a1", "Pallavi");
            My_dic.Add("a2", "Suma.N");
            My_dic.Add("a3", "Harshitha");
            Console.WriteLine("Dictionary");
            foreach(KeyValuePair<string,string>element in My_dic)
            {
                Console.WriteLine("key:{0} and value:{1}", element.Key, element.Value);
            }
            Console.WriteLine("----------------------------------------------------- ");
            //for hashtag
            Hashtable My_hashtable = new Hashtable();
            My_hashtable.Add("A1", "Priyanka");
            My_hashtable.Add("A2", "Ashwini");
            My_hashtable.Add("A3", "Madhu.I");
            Console.WriteLine("Hashtable");
            foreach (DictionaryEntry element in My_hashtable)
            {
                Console.WriteLine("key:{0} and value:{1}", element.Key, element.Value);
            }
            Console.ReadKey();

        }
    }
}
