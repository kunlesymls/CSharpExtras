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
                string ouput = string.Empty;
                Console.WriteLine("------------------------!");

                Console.WriteLine("Type any Number!");
                string input = Console.ReadLine();




                var inputLength = input.Length;
                if (inputLength.Equals(1))
                {
                    ouput = ConvertTwoDigit(input);
                }
                else if (inputLength.Equals(2))
                {
                    ouput = TwoJustDigitConverter(input);
                }


                Console.WriteLine("------------------------!");
                Console.WriteLine($"Generated output is \" {ouput} \"");
                Console.WriteLine("------------------------!");

                Console.WriteLine("Please type y to continue or n to quit");
                exit = Console.ReadLine();
            } while (exit != null && exit.ToLower().Equals("y"));

        }

        private static string TwoJustDigitConverter(string twoInput)
        {
            var twoDigitStringBuuilder = new StringBuilder();
            string twoDigitOutput = string.Empty;

            if (twoInput.StartsWith("0"))
            {
                twoDigitOutput = RemoveZeroFromTheBegining(twoInput);
                twoDigitStringBuuilder.Append(ConvertTwoDigit(twoDigitOutput));
            }
            else if (twoInput.Substring(0, 1) != ("1"))
            {
                var spiltInput = twoInput.ToCharArray();
                for (int i = 0; i < spiltInput.Length; i++)
                {
                    twoDigitStringBuuilder.Append(i == 0
                        ? $"{ConvertTwoDigit($"{spiltInput[i]}0")} - "
                        : ConvertTwoDigit($"{spiltInput[i]}"));
                }
            }
            else
            {
                twoDigitStringBuuilder.Append(ConvertTwoDigit(twoInput));
            }

            return twoDigitStringBuuilder.ToString();
        }

        private static string RemoveZeroFromTheBegining(string input)
        {
            var removedInput = input.Remove(0, 1);
            return removedInput;
        }

        public static string ConvertTwoDigit(string num)
        {
            switch (num)
            {
                case "0":
                    return "Zero";
                case "1":
                    return "One";
                case "2":
                    return "Two";
                case "3":
                    return "Three";
                case "4":
                    return "Four";
                case "5":
                    return "Five";
                case "6":
                    return "Six";
                case "7":
                    return "Seven";
                case "8":
                    return "Eight";
                case "9":
                    return "Nine";
                case "10":
                    return "Ten";
                case "11":
                    return "Eleven";
                case "12":
                    return "Twelve";
                case "13":
                    return "Thirteen";
                case "14":
                    return "Fourteen";
                case "15":
                    return "Fifteen";
                case "16":
                    return "Sixteen";
                case "17":
                    return "Seventeen";
                case "18":
                    return "Eighteen";
                case "19":
                    return "Nineteen";
                case "20":
                    return "Twenty";
                case "30":
                    return "Thirty";
                case "40":
                    return "Forty";
                case "50":
                    return "Fifty";
                case "60":
                    return "Sixty";
                case "70":
                    return "Seventy";
                case "80":
                    return "Eighty";
                case "90":
                    return "Ninety";

                default:
                    return "Not a two digit number";
            }

        }
    }
}
