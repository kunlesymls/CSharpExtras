using System.Text;

namespace CSharpFundamentals
{
    public static class ChapterOne
    {
        /// <summary>
        /// Exercise One (Dealing with Postive Negative Sequence of Number)
        /// </summary>
        /// <param name="sequenceLength"></param>
        /// <param name="startingNumber"></param>
        /// <returns>string</returns>
        public static string PositiveNegativeSequence(int sequenceLength, int startingNumber)
        {
            var sb = new StringBuilder();
            int incremental = startingNumber + (startingNumber + 1);
            for (int i = 1; i <= sequenceLength; i++)
            {
                if (i <= 1)
                {
                    sb.Append($"{startingNumber}, ");
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        startingNumber = startingNumber - incremental;
                        sb.Append($"{startingNumber}, ");
                    }
                    else
                    {
                        startingNumber = startingNumber + incremental;
                        sb.Append($"{startingNumber}, ");
                    }
                    incremental += 2;
                }
            }
            return sb.ToString();
        }

        public static string PositiveNegativeSequence(int sequenceLength)
        {
            var sb = new StringBuilder();
            int startingNumber = 2;
            int incremental = startingNumber + (startingNumber + 1);
            for (int i = 1; i <= sequenceLength; i++)
            {
                if (i <= 1)
                {
                    sb.Append($"{startingNumber}, ");
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        startingNumber = startingNumber - incremental;
                        sb.Append($"{startingNumber}, ");
                    }
                    else
                    {
                        startingNumber = startingNumber + incremental;
                        sb.Append($"{startingNumber}, ");
                    }
                    incremental += 2;
                }
            }
            return sb.ToString();
        }
    }
}