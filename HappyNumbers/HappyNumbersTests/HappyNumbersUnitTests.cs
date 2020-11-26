using ConsoleHappyNumbers;
using System;
using Xunit;

namespace HappyNumbersTests
{
    public class HappyNumbersUnitTests
    {
        HappyNumbers happyNumbers = new HappyNumbers();
        [Fact]
        public void ShouldGetTheFirstNumberAndReturnSuccess()
        {
            string result = happyNumbers.GetFirstNumber("25");
            Assert.Equal("2", result);
        }
        [Fact]
        public void ShouldReturnTheInputNumbersSeparatelly()
        {
            string[] numbers = { "2", "5" };
            string[] result = happyNumbers.GetNumbers("25");
            Assert.Equal(numbers, result);
        }
    }
}
