using System;
using System.Collections.Generic;


namespace ArrayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = { "this", "is", "my", "array" };
            Console.WriteLine("Please select an index from 0 to 3");
            int strIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strArray[strIndex]);

            int[] intArray = { 500, 400, 300, 200 };
            Console.WriteLine("Please select an index.");
            int intIndex = Convert.ToInt32(Console.ReadLine());
            bool caseBool = false;
            do
            {
                switch (intIndex)
                {
                    case 0:
                        Console.WriteLine(intArray[intIndex]);
                        caseBool = true;
                        break;
                    case 1:
                        Console.WriteLine(intArray[intIndex]);
                        caseBool = true;
                        break;
                    case 2:
                        Console.WriteLine(intArray[intIndex]);
                        caseBool = true;
                        break;
                    case 3:
                        Console.WriteLine(intArray[intIndex]);
                        caseBool = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, that index doesn't exist.");
                        Console.WriteLine("Please select an index.");
                        intIndex = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!caseBool);

            List<string> strList = new List<string>();
            strList.Add("check");
            strList.Add("out");
            strList.Add("this");
            strList.Add("list");
            Console.WriteLine("Please select an index from 0 to 3.");
            int listIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strList[listIndex]);
            Console.ReadLine();
        }
    }
}
