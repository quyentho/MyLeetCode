using System;

namespace _7._Reverse_Integer
{
    // https://leetcode.com/problems/reverse-integer/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse2(int.MaxValue));
        }

        public static int Reverse(int x)
        {
            try
            {
                var stringValue = x.ToString().ToCharArray();

                if (stringValue[0].Equals('-'))
                {
                    Array.Reverse(stringValue, 1, stringValue.Length - 1);
                }
                else
                {
                    Array.Reverse(stringValue);
                }

                string stringResult = new string(stringValue);

                int result = Int32.Parse(stringResult);

                return result;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }

        public static int Reverse2(int x)
        {
            int reverse = 0;

            while (x != 0)
            {
                int lastNumber = x % 10;

                x /= 10;

                if (reverse > int.MaxValue / 10 || (reverse == int.MaxValue / 10 && lastNumber > 7))
                {
                    return 0;
                }

                if (reverse < int.MinValue / 10 || reverse == int.MaxValue / 10 && lastNumber < -8)
                {
                    return 0;
                }

                reverse = reverse * 10 + lastNumber;
            }

            return reverse;
        }
    }
}
