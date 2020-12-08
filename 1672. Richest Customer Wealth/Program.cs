using System;
using System.Linq;

namespace _1672._Richest_Customer_Wealth
{
    // https://leetcode.com/problems/richest-customer-wealth/
    class Program
    {
        static void Main(string[] args)
        {

            int[][] input = new int[2][] { new int[3] { 1, 2, 3 }, new int[3] { 3, 2, 1 } };
            Console.WriteLine(MaximumWealth2(input));
        }

        public static int MaximumWealth(int[][] accounts)
        {
            int wealth = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int sum = accounts[i].Sum();

                if (sum > wealth)
                {
                    wealth = sum;
                }
            }

            return wealth;
        }

        public static int MaximumWealth2(int[][] accounts) => accounts.Select(row => row.Sum()).Max();
    }
}
