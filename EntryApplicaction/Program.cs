using CSharpFundamentals;
using MathLibrary;
using System;
using System.Text;

namespace EntryApplicaction
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Exercise one of Chapter One

            //Console.WriteLine("Please type the sequence length");
            //int sequenceLenght = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Please type the first number of the sequence");
            //int startingNumber = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine(ChapterOne.PositiveNegativeSequence(sequenceLenght, startingNumber));
            //Console.WriteLine(ChapterOne.PositiveNegativeSequence(sequenceLenght));

            #endregion Exercise one of Chapter One

            #region Number to Word

            //Console.WriteLine("Number to Word Converter!");

            //string exit = "";
            //do
            //{
            //    var ouput = new StringBuilder();
            //    Console.WriteLine("------------------------!");

            //    Console.WriteLine("Type any Number!"); string input = Console.ReadLine();

            //    ouput.Append(WordConverter.GetnumberConverter(input));

            //    Console.WriteLine("------------------------!"); Console.WriteLine($"Generated output is \" {ouput} \"");
            //    Console.WriteLine("------------------------!");

            //    Console.WriteLine("Please type y to continue or n to quit");
            //    exit = Console.ReadLine();
            //} while (exit != null && exit.ToLower().Equals("y"));

            #endregion Number to Word

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

            #endregion ConvertFromBaseTen

            #region Binary

            //Console.WriteLine("------------------------!");
            //Console.WriteLine("Type the base");
            //int inputBase = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("------------------------!");

            //Console.WriteLine("Which Operation Did you want to perform");
            //string operation = Console.ReadLine();

            //Console.WriteLine("Type First Input");
            //string inputOne = Console.ReadLine();
            //Console.WriteLine("------------------------!");

            //Console.WriteLine("Type Second Input");
            //string inputTwo = Console.ReadLine();
            // Console.WriteLine(BinaryConverter.MainBinaryConverter(inputOne, inputBase, inputTwo, operation));

            #endregion Binary

            #region Shapes

            //Console.WriteLine("What shape did you want to solve?");
            //Console.WriteLine("=-----------------------");

            //Console.WriteLine("Please type \"S for Square and \"R for Rectangle");
            //string shapeInput = Console.ReadLine();

            //IShape shape = null;
            //if (shapeInput.ToUpper().Equals("S"))
            //{
            //    Console.WriteLine("Please supply value for Length");
            //    double squareLength = Convert.ToDouble(Console.ReadLine());
            //    shape = new Square(squareLength);
            //}
            //else if (shapeInput.ToUpper().Equals("R"))
            //{
            //    Console.WriteLine("Please supply value for Length");
            //    double recLength = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Please supply value for Breadth");
            //    double recbreadth = Convert.ToDouble(Console.ReadLine());
            //    shape = new Rectangle(recLength, recbreadth);
            //}
            //else if (shapeInput.ToUpper().Equals("C"))
            //{
            //    Console.WriteLine("Please supply value for Radius");
            //    double circleRad = Convert.ToDouble(Console.ReadLine());

            //    shape = new Circle();
            //}

            //Console.WriteLine($"The Area of the Shape is {shape.GetArea()}");
            //Console.WriteLine($"The Perimeter of the Shape is {shape.GetPerimeter()}");

            #endregion Shapes


            Console.WriteLine("Using doubles:");
            double a = 0.1;
            double b = 0.2;
            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }
        }
    }
}