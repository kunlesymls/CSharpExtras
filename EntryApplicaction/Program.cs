using MathLibrary;
using System;

namespace EntryApplicaction
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Number to Word
            //Console.WriteLine("Number to Word Converter!");


            //string exit = "";
            //do
            //{
            //    var ouput = new StringBuilder();
            //    Console.WriteLine("------------------------!");

            //    Console.WriteLine("Type any Number!");
            //    string input = Console.ReadLine();

            //    ouput.Append(WordConverter.GetnumberConverter(input));


            //    Console.WriteLine("------------------------!");
            //    Console.WriteLine($"Generated output is \" {ouput} \"");
            //    Console.WriteLine("------------------------!");

            //    Console.WriteLine("Please type y to continue or n to quit");
            //    exit = Console.ReadLine();
            //} while (exit != null && exit.ToLower().Equals("y"));
            #endregion

            Console.WriteLine("------------------------!");
            Console.WriteLine("Type the base");
            int inputBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------!");

            Console.WriteLine("Which Operation Did you want to perform");
            string operation = Console.ReadLine();


            Console.WriteLine("Type First Input");
            string inputOne = Console.ReadLine();
            Console.WriteLine("------------------------!");

            Console.WriteLine("Type Second Input");
            string inputTwo = Console.ReadLine();


            #region ConvertFromBaseTen
            //if (inputBase > 9)
            //{
            //    Console.WriteLine($"Sorry we dont do conversion for {inputBase}");
            //    Console.WriteLine("Try Number between 2 - 9. Thank You ");
            //}
            //else
            //{
            //    Console.WriteLine($"Answer is equal to {ConvertFromBasetenToAnyBase(input, inputBase)}");
            //} 
            #endregion

            Console.WriteLine(BinaryConverter.MainBinaryConverter(inputOne, inputBase, inputTwo, operation));

        }


    }
}
