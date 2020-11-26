using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHappyNumbers
{
    public class HappyNumbers
    {
        public string GetFirstNumber(string input)
        {
            var inputNumbers = input.ToCharArray();

            return inputNumbers[0].ToString();
        }

        public char[] GetNumbers(string input)
        {
            var inputNumbers = input.ToCharArray();
            return inputNumbers;
        }
    }
}
