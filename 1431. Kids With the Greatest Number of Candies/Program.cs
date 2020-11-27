using System;
using System.Collections.Generic;
using System.Linq;

namespace _1431._Kids_With_the_Greatest_Number_of_Candies
{
    // https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
    //Input: candies = [4,2,1,1,2], extraCandies = 1
    //Output: [true,false,false,false,false]
    class Program
    {
        static void Main(string[] args)
        {
            int[] candies = { 4, 2, 1, 1, 2 };
            int extraCandies = 1;
            List<bool> result = (List<bool>)KidsWithCandies(candies, extraCandies);
            for (int i = 0; i < candies.Length; i++)
            {
               Console.WriteLine(result[i]);
            }
        }

        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int greatestCandies = candies.Max();
            List<bool> result = new List<bool>();
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= greatestCandies)
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }    
            }

            return result;

        }
    }
}
