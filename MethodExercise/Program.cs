using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "aabcc";

            var charArray = numbers.ToCharArray();

            //var distinctNumber = charArray.Distinct();
            //foreach (var item in distinctNumber)
            //{
            //    var numberOfAppearance = charArray.Count(x => x.ToString().Equals(item.ToString()));
            //    Console.WriteLine($"This number ({item.ToString()}) appears ({numberOfAppearance}) times");
            //}
            var resultstorageList = new List<ResultStorage>();
            var dictionaryList = GetResult(charArray);

            //foreach (KeyValuePair<string, string> item in dictionaryList)
            //{
            //    Console.WriteLine($"This number ({item.Key}) appears ({item.Value}) times");
            //}
            foreach (var item in dictionaryList)
            {
                Console.WriteLine($"This number ({item.NormalValue}) appears ({item.NumberaOfOccurence}) times");
            }
        }

        //static Dictionary<string, string> GetResult(Char[] myArray)
        //{
        //    var dictionaryList = new Dictionary<string, string>();

        //    for (int i = 0; i < myArray.Length; i++)
        //    {
        //        if (dictionaryList.ContainsKey(myArray[i].ToString()))
        //        {
        //            int myValue = Convert.ToInt32(dictionaryList[myArray[i].ToString()]);
        //            dictionaryList[myArray[i].ToString()] = (myValue + 1).ToString();
        //        }
        //        else
        //        {
        //            dictionaryList.Add(myArray[i].ToString(), "1");
        //        }
        //    }
        //    return dictionaryList;
        //}

        static List<ResultStorage> GetResult(Char[] myArray)
        {
            var resultStorageList = new List<ResultStorage>();

            for (int i = 0; i < myArray.Length; i++)
            {
                var isExist = resultStorageList.FirstOrDefault(x => x.NormalValue.Equals(myArray[i].ToString()));
                if (isExist != null)
                {
                    isExist.NumberaOfOccurence = isExist.NumberaOfOccurence + 1;
                }
                else
                {
                    resultStorageList.Add(new ResultStorage()
                    {
                        NormalValue = myArray[i].ToString(),
                        NumberaOfOccurence = 1
                    });                   
                }           

            }
            return resultStorageList;

        }
    }
}


