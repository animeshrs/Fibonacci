using Repository;
using System.Collections.Generic;

namespace Fibonacci
{
    public class MathService : IGenericRepository // When implemented, will correspond to Repository Design Pattern
    {
        public int GetFibonacciValue(int number)
        {
            if (number <= 1)
                return number;

            var result = CalculateFibonacci(number);
            return result;
        }

        private int CalculateFibonacci(int number)
        {
            var firstNum = 0;
            var secondNum = 1;

            var finalResult = new List<int>();
            for (var i = firstNum; i <= number; i++)
            {
                var tempNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = tempNum;

                finalResult.Add(tempNum);
            }
            return finalResult[number - 1]; // indices are 0 based
        }
    }
}
