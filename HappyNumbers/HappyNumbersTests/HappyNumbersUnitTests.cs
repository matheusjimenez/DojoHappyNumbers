using ConsoleHappyNumbers;
using System;
using Xunit;

namespace HappyNumbersTests
{
    public class HappyNumbersUnitTests
    {
        [Fact]
        public void ShouldGetTheFirstNumberAndReturnSuccess()
        {
            HappyNumbers happyNumbers = new HappyNumbers();
            string result = happyNumbers.GetFirstNumber("25");
            Assert.Equal("2", result);
        }
    }
}
