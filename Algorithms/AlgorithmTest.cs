using System;
using Xunit;

namespace DeveloperSample.Algorithms
{
    public class AlgorithmTest
    {
        [Fact]
        public void CanGetFactorial()
        {
            Assert.Equal(24, Algorithms.GetFactorial(4));
        }

        [Fact]
        public void CanGetFactorialOfThree()
        {
            Assert.Equal(6, Algorithms.GetFactorial(3));
        }

        [Fact]
        public void GetFactorialAboveTwelve()
        {
            Assert.Throws<ArgumentException>(() => Algorithms.GetFactorial(13));
        }

        [Fact]
        public void GetFactorialOfZero()
        {
            Assert.Equal(1, Algorithms.GetFactorial(0));
        }

        [Fact]
        public void GetFactorialOfOne()
        {
            Assert.Equal(1, Algorithms.GetFactorial(1));
        }

        [Fact]
        public void GetFactorialOfNegative()
        {
            Assert.Throws<ArgumentException>(() => Algorithms.GetFactorial(-1));
        }

        [Fact]
        public void CanFormatSeparators()
        {
            Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", "c"));
        }

        [Fact]
        public void FormatSingleItem()
        {
            Assert.Equal("a", Algorithms.FormatSeparators("a"));
        }

        [Fact]
        public void CanFormatSeparatorsWithTwoVars()
        {
            Assert.Equal("a and b", Algorithms.FormatSeparators("a", "b"));
        }

        [Fact]
        public void FormatNoItems()
        {
            Assert.Equal(string.Empty, Algorithms.FormatSeparators());
        }

        [Fact]
        public void FormatNullItem()
        {
            Assert.Throws<ArgumentNullException>(() => Algorithms.FormatSeparators(null));
        }


        [Fact]
        public void FormatMultipleItems()
        {
            Assert.Equal("a, b, c, d and e", Algorithms.FormatSeparators("a", "b", "c", "d", "e"));
        }
    }
}
