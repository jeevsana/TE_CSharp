using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class File_ReadWrite
    {
        //Create and store
        public void Write()
        {

            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13122\Files1.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);
            try
            {
                writer.WriteLine("7 x 1 = 7\r\n7 x 2 = 14\r\n7 x 3 = 21\r\n7 x 4 = 28\r\n7 x 5 = 30\r\n7 x 6 = 42\r\n7 x 7 = 49\r\n7 x 8 = 56\r\n7 x 9 = 63\r\n7 x 10 = 70");

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                writer.Close();
                fileStream.Close();
            }

        }
        //  Read 
        public void read()
        {

            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13122\Files1.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fileStream);
            try
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine(contents);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }

        }
    }
    internal class Files1
    {
        public static void Main()
        {
            File_ReadWrite rw = new File_ReadWrite();
            rw.Write();
            rw.read();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----To read the first line from a file--------------------");


            //Move
            //  File.Move(@"C:\Users\EI13134\17_task.txt", @"C:\Users\EI13134\source\17_task.txt");

            //Copy
            string path = @"C:\Users\EI13122\Files1.txt";
            string destination = @"C:\Users\EI13122\source\Files1_Copy.txt";
             File.Copy(path, destination);

            //Delete Files1
           //File.Delete(path);

            //Read First line from the file
            string[] content;
            content = File.ReadAllLines(path);
            Console.WriteLine(content[0]);

             var lineCount = File.ReadLines(@"C:\Users\EI13122\Files1.txt").Count();
             Console.WriteLine("---------------Number of lines--------------");
             Console.WriteLine(lineCount);


        }
    }
}
