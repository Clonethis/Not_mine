using System;
using System.IO;  // include the System.IO namespace
namespace First
{
    public class WorkWithFiles
    {
        public void Nice()
        {
            string hello = " Nice ";
            try
            {
            File.WriteAllText("./text.txt",hello);  // use the file class with methods
                Console.Write("Current dir: " + Directory.GetCurrentDirectory());
            }
            catch(Exception e)
            {

            Console.WriteLine("nice");
            }
        }
    }
}

