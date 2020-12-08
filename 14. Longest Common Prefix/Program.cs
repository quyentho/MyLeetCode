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
            if (strs.Length == 0)
            {
                return string.Empty;
            }

            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j].Length == i || strs[j][i] != strs[0][i])
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }

            return strs[0];
        }
    }
}
