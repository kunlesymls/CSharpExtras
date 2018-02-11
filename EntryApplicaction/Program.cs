using System;
using System.Text;

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

            //    ouput.Append(MainConverter.GetnumberConverter(input));


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

            string valOne = ConvertionFromOtherBaseToBaseTen(inputOne, inputBase);
            string valTwo = ConvertionFromOtherBaseToBaseTen(inputTwo, inputBase);
            int sum = 0;
            if (operation.Equals("+"))
            {
                sum = Convert.ToInt32(valOne) + Convert.ToInt32(valTwo);
            }
            else if (operation.Equals("-"))
            {
                sum = Convert.ToInt32(valOne) - Convert.ToInt32(valTwo);

            }
            else if (operation.Equals("*"))
            {
                sum = Convert.ToInt32(valOne) * Convert.ToInt32(valTwo);

            }
            else if (operation.Equals("/"))
            {
                sum = Convert.ToInt32(valOne) / Convert.ToInt32(valTwo);

            }
            else
            {
                Console.WriteLine("Invalid Operation Selected");
            }

            Console.WriteLine(ConvertFromBasetenToAnyBase(sum, inputBase));

        }

        private static string ConvertionFromOtherBaseToBaseTen(string input, int inputBase)
        {
            bool isBadData = false;
            double result = 0;

            var inputArray = input.ToCharArray();
            int currentPower = inputArray.Length - 1;
            foreach (var number in inputArray)
            {
                if (Convert.ToInt32(number.ToString()) >= inputBase)
                {
                    isBadData = true;
                }
            }
            if (isBadData)
            {
                return "You Supplied bad data";
            }
            else
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    double mycal = Math.Pow(Convert.ToDouble(inputBase), Convert.ToDouble(currentPower));

                    double val = Convert.ToInt32(inputArray[i].ToString()) * mycal;

                    result = result + val;

                    currentPower -= 1;
                }

                return result.ToString();
            }
        }

        private static string ConvertFromBasetenToAnyBase(int input, int inputBase)
        {
            var anyBaseSb = new StringBuilder();
            if (input < inputBase && input > 0)
            {
                anyBaseSb.Append($"Answer is {inputBase}");
            }
            else
            {
                do
                {
                    anyBaseSb.Append(input % inputBase);
                    input = input / inputBase;
                } while (input >= inputBase);

                anyBaseSb.Append(input);
            }

            return Reverse(anyBaseSb.ToString());
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
