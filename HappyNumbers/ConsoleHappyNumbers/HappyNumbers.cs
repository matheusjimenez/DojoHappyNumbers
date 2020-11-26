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
            var firstNumber = inputNumbers[0];
            return firstNumber.ToString();
        }
    }
}
