using System;
using System.Text;

namespace TwinSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArrayA = { "cdab", "dcba" };
            string[] stringArrayB = { "abcd", "abcd" };
            string[] resultArray = new string[stringArrayA.Length];

            for (int i = 0; i < stringArrayA.Length; i++)
            {
                string getStringA = stringArrayA[i];
                string getStringB = stringArrayB[i];

                var evenResult = PerformEvenOperation(getStringA);
                var oldResult = PerformOldOperation(evenResult);

                if (oldResult.Equals(getStringB))
                {
                    resultArray[i] = "Yes";
                }
                else
                {
                    resultArray[i] = "No";
                }
            }
            foreach (var item in resultArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static string PerformEvenOperation(string input)
        {
            var builder = new StringBuilder();
            char[] inputArray = input.ToCharArray();
            int swappedNo = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i == 0)
                {
                    swappedNo = i + 2;
                    builder.Append(inputArray[swappedNo].ToString());
                }

                else if (i >= 2 && i % 2 == 0)
                {
                    if (i == swappedNo)
                    {
                        int count = i - 2;
                        builder.Append(inputArray[count].ToString());
                    }
                    else
                    {
                        swappedNo = i + 2;
                        builder.Append(inputArray[swappedNo].ToString());
                    }

                }
                else
                {
                    builder.Append(inputArray[i].ToString());
                }
            }
            return builder.ToString();
        }
        static string PerformOldOperation(string input)
        {
            var builder = new StringBuilder();
            char[] inputArray = input.ToCharArray();
            int swappedNo = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i == 1)
                {
                    swappedNo = i + 2;
                    builder.Append(inputArray[swappedNo].ToString());
                }

                else if (i >= 2 && i % 2 == 1)
                {
                    if (i == swappedNo)
                    {
                        int count = i - 2;
                        builder.Append(inputArray[count].ToString());
                    }
                    else
                    {
                        swappedNo = i + 2;
                        builder.Append(inputArray[swappedNo].ToString());
                    }
                }
                else
                {
                    builder.Append(inputArray[i].ToString());
                }
            }
            return builder.ToString();
        }
    }
}
