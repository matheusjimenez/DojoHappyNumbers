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
            char[] numbers = { '2', '5' };
            char[] result = happyNumbers.GetNumbers("25");
            Assert.Equal(numbers, result);
        }
        [Fact]
        public void ShouldPowerTheInputedNumbers()
        {
            string numbers = "35";
            var separetelyNumbers = happyNumbers.GetNumbers(numbers);
            var poweredNumbers = int.Parse(separetelyNumbers[0].ToString());
        }
    }
}
