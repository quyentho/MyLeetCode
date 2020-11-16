using System;
using System.Collections.Generic;

namespace _13._Roman_to_Integer
{
    // https://leetcode.com/problems/roman-to-integer/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }

        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanNumberDictionary = new Dictionary<char, int>();
            romanNumberDictionary.Add('I', 1);
            romanNumberDictionary.Add('V', 5);
            romanNumberDictionary.Add('X', 10);
            romanNumberDictionary.Add('L', 50);
            romanNumberDictionary.Add('C', 100);
            romanNumberDictionary.Add('D', 500);
            romanNumberDictionary.Add('M', 1000);

            int result = romanNumberDictionary[s[0]];
            for (int i = 1; i < s.Length; i++)
            {
                if (romanNumberDictionary[s[i - 1]] < romanNumberDictionary[s[i]])
                {
                    result = result - 2 * romanNumberDictionary[s[i - 1]];
                }

                result += romanNumberDictionary[s[i]];
            }

            return result;
        }
    }
}
