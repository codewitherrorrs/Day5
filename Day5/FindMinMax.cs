using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class FindMinMax<T> where T : IComparable<T>
    {

        public void MaxFind(int firstValue, int secondValue,int thirdValue)
        {
            if(firstValue > secondValue && firstValue > thirdValue)
            {
                Console.WriteLine($"First Value is greater : {firstValue}");
            }
            else if (secondValue > firstValue && secondValue > thirdValue)
            {
                Console.WriteLine($"Second Value is greater : {secondValue}");
            }
            else
            {
                Console.WriteLine($"Third value is greater : {thirdValue}");
            }
        }
        public void FindMax(T firstValue,T secondValue,T thirdValue)
        {
            if(secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            { 
                Console.WriteLine($"Second is gretaer : {secondValue}");
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                Console.WriteLine($"Third is greater : {thirdValue}");
            }
            else
            {
                Console.WriteLine(firstValue);
            }
        }
    }
}
