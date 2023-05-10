using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class FindMinMax<T> where T : IComparable<T>
    {       
        public void FindMax(T firstValue,T secondValue,T thirdValue)
        {
            if(secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            { 
                Console.WriteLine($"Second is gretaer : {secondValue}");
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                Console.WriteLine($"Third is gretaer : {thirdValue}");
            }
            else
            {
                Console.WriteLine(firstValue);
            }
        }
    }
}
