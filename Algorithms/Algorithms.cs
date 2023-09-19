using System;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Input must be a non-negative integer");

            int factorialResult = 1;
            for (int i = 1; i <= n; i++)
            {
                factorialResult *= i;
            }
            return factorialResult;
        }

        public static string FormatSeparators(params string[] items)
        {
            if (items == null || items.Length == 0)
                return string.Empty;

            if (items.Length == 1)
                return items[0];

            string stringResult = string.Join(", ", items, 0, items.Length - 1);
            stringResult += " and " + items[items.Length - 1];
            return stringResult;
        }
    }
}
