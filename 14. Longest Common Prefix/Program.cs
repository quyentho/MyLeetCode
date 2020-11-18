using System;
using System.Linq;

namespace _14._Longest_Common_Prefix
{
    //https://leetcode.com/problems/longest-common-prefix/
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "flower", "flow", "flight" };

            Console.WriteLine(LongestCommonPrefix(input));
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string minLengthString = strs.Min();

            string commonPrefix = string.Empty;

            for (int i = 0; i < minLengthString.Length; i++)
            {
                commonPrefix = string.Concat(commonPrefix, strs[0][i]);

                for (int j = 1; j < 3; j++)
                {
                    if (!strs[j][i].ToString().Equals(commonPrefix[i].ToString()))
                    {
                        return commonPrefix.Remove(i);
                    }
                }
            }

            return commonPrefix;
        }
    }
}
