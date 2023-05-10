using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class DeleteElement
    {
        public void DeleteInt(int[] arr,int position) 
        {
            int[] temp = new int[arr.Length];
            int pos = position;
            if(pos < 0 || pos >= arr.Length) 
            {
                Console.WriteLine("Invalid Position");
            }
            int i = 0;
            int count = 0;
            for(i= 0; i < temp.Length; i++)
            {
                if(i != position) 
                {
                    temp[count] = arr[i];
                    count++;
                }
            }
            foreach(int k in temp)
            {
                if (k == 0)
                {
                    continue;
                }
                Console.Write($"{k} ");
            }
        }

        //Delete Char Element at Specific Position.
        public void DeleteChar(char[] arr, int position)
        {
            char[] temp = new char[arr.Length];
            int pos = position;
            if (pos < 0 || pos >= arr.Length)
            {
                Console.WriteLine("Invalid Position");
            }
            int i = 0;
            int count = 0;
            for (i = 0; i < temp.Length; i++)
            {
                if (i != position)
                {
                    temp[count] = arr[i];
                    count++;
                }
            }
            foreach (char k in temp)
            {
                if (k == 0)
                {
                    continue;
                }
                Console.Write($"{k} ");
            }
        }
    }
}
