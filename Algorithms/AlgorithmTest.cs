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
        public void CanFormatSeparators()
        {
            Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", "c"));
        }
        [Fact]
        public void FormatSingleItem()
        {
            Assert.Equal("a", Algorithms.FormatSeparators("a"));
        }
    }
}