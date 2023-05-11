using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class FindMinimum
    {
        public void MinFind(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue < secondValue && firstValue < thirdValue)
            {
                Console.WriteLine($"First Value is smaller : {firstValue}");
            }
            else if (secondValue < firstValue && secondValue < thirdValue)
            {
                Console.WriteLine($"Second Value is smaller : {secondValue}");
            }
            else
            {
                Console.WriteLine($"Third value is smaller : {thirdValue}");
            }
        }
        //public class FindMinimum
        public void MinFindDouble(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue < secondValue && firstValue < thirdValue)
            {
                Console.WriteLine($"First Value is smaller : {firstValue}");
            }
            else if (secondValue < firstValue && secondValue < thirdValue)
            {
                Console.WriteLine($"Second Value is smaller : {secondValue}");
            }
            else
            {
                Console.WriteLine($"Third value is smaller : {thirdValue}");
            }
        }
        //Minimum Using String
        public void MinFindString(string firstValue, string secondValue, string thirdValue)
        {
            if (firstValue.Length < secondValue.Length && firstValue.Length < thirdValue.Length)
            {
                Console.WriteLine($"First String is smaller : {firstValue}");
            }
            else if (secondValue.Length < firstValue.Length && secondValue.Length < thirdValue.Length)
            {
                Console.WriteLine($"Second String is smaller : {secondValue}");
            }
            else
            {
                Console.WriteLine($"Third value is smaller : {thirdValue}");
            }
        }
    }
}
