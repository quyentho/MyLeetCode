using System;

namespace _509._Fibonacci_Number
{
    // https://leetcode.com/problems/fibonacci-number/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib2(4));
        }

        public static int Fib(int N)
        {
            if (N == 0 || N == 1)
            {
                return N;
            }

            int[] fibArr = new int[N + 1];
            fibArr[0] = 0;
            fibArr[1] = 1;
            for (int i = 2; i <= N; i++)
            {
                fibArr[i] = fibArr[i - 1] + fibArr[i - 2];
            }

            return fibArr[N];
        }

        public static int Fib2(int N)
        {
            if (N <= 1)
            {
                return N;
            }

            return Fib2(N - 1) + Fib2(N - 2);
        }
    }
}
