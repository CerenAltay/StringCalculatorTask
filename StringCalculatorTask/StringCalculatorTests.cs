using System;
using Xunit;

namespace StringCalculatorTask
{
    public class StringCalculatorTests
    {
        private StringCalculator _stringCalculator = new StringCalculator();
        
        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            var result = _stringCalculator.Add("");

            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        public void Add_OneNumber_ReturnsThatNumber(string numbers, int expected)
        {
            var result = _stringCalculator.Add(numbers);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("3,4", 7)]
        public void Add_TwoNumbers_ReturnsSum(string numbers, int expected)
        {
            var result = _stringCalculator.Add(numbers);

            Assert.Equal(expected, result);
        }
    }
}
