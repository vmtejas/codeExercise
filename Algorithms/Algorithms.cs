using System;
using System.Linq;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Input must be a non-negative integer");

            if (n > 12)
                throw new ArgumentException("Input is large and must be below 12");

            int factorialResult = 1;
            for (int i = 1; i <= n; i++)
            {
                factorialResult *= i;
            }
            return factorialResult;
        }

        /*public static string FormatSeparators(params string[] items)
        {
            if (items == null || items.Length == 0)
                return string.Empty;

            if (items.Length == 1)
                return items[0];

            string stringResult = string.Join(", ", items, 0, items.Length - 1);
            stringResult += " and " + items[^1];
            return stringResult;
        }*/

        /*public static string FormatSeparators(params string[] items) => items.Length switch
        {
            0 => string.Empty,
            1 => items[0],
            _ => $"{string.Join(", ", items, 0, items.Length - 1)} and {items[^1]}"
        };*/

        public static string FormatSeparators(params string[] items)
        {
            return items switch
            {
                null => throw new ArgumentNullException(nameof(items), "Input array is null."),
                { Length: 0 } => string.Empty,
                { } when items.Any(item => item == null) => throw new ArgumentNullException(nameof(items), "One or more items are null."),
                { Length: 1 } => items[0],
                _ => $"{string.Join(", ", items, 0, items.Length - 1)} and {items[^1]}"
            };
        }
    }
}
