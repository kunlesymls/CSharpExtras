using System;
using System.Text;

namespace MathLibrary
{
    public static class BinaryConverter
    {

        public static string MainBinaryConverter(string inputOne, int inputBase, string inputTwo, string operation)
        {
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
                return "Invalid Operation Selected";
            }

            return ConvertFromBasetenToAnyBase(sum, inputBase);
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
