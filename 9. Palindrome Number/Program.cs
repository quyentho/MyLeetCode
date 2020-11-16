using System;

namespace _9._Palindrome_Number
{
    // https://leetcode.com/problems/palindrome-number/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome2(121));
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int revertedNumber = Reverse(x);

            if (x - revertedNumber == 0)
            {
                return true;
            }

            return false;
        }

        public static int Reverse(int number)
        {
            int revertedNumber = 0;

            while (number != 0)
            {
                int lastNumber = number % 10;

                if (revertedNumber > int.MaxValue / 10 || (revertedNumber == int.MaxValue / 10 && lastNumber > 7))
                {
                    return 0;
                }

                if (revertedNumber < int.MinValue / 10 || (revertedNumber == int.MinValue / 10 && lastNumber < -8))
                {
                    return 0;
                }

                revertedNumber = revertedNumber * 10 + lastNumber;

                number /= 10;
            }

            return revertedNumber;
        }

        public static bool IsPalindrome2(int x)
        {
            int revertedNumber = 0;

            // Special cases:
            // As discussed above, when x < 0, x is not a palindrome.
            // Also if the last digit of the number is 0, in order to be a palindrome,
            // the first digit of the number also needs to be 0.
            // Only 0 satisfy this property.
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;

                x /= 10;
            }

            // When the length is an odd number, we can get rid of the middle digit by revertedNumber/10
            // For example when the input is 12321, at the end of the while loop we get x = 12, revertedNumber = 123,
            // since the middle digit doesn't matter in palidrome(it will always equal to itself), we can simply get rid of it.
            return revertedNumber == x || revertedNumber / 10 == x;
        }
    }
}
