using System;
using System.Text;

namespace NumberToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number to Word Converter!");


            string exit = "";
            do
            {
                var ouput = new StringBuilder();
                Console.WriteLine("------------------------!");

                Console.WriteLine("Type any Number!");
                string input = Console.ReadLine();

                ouput.Append(MainConverter.GetnumberConverter(input));


                Console.WriteLine("------------------------!");
                Console.WriteLine($"Generated output is \" {ouput} \"");
                Console.WriteLine("------------------------!");

                Console.WriteLine("Please type y to continue or n to quit");
                exit = Console.ReadLine();
            } while (exit != null && exit.ToLower().Equals("y"));

        }


    }
}
