using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some text to add to the file.");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\jonre\Desktop\Basic_C#_Programs\FileIO\logs\log.txt", text);
            string result = File.ReadAllText(@"C:\Users\jonre\Desktop\Basic_C#_Programs\FileIO\logs\log.txt");
            Console.WriteLine("The text '{0}' was added to the log.txt file.", result);
            Console.ReadLine();
        }
    }
}
