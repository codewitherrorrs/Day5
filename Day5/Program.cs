﻿namespace Day5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FindMinMax<int> findMinMax = new FindMinMax<int>();
            FindMinMax<double> findMax = new FindMinMax<double>();
            //Max With Second Number.
            findMinMax.FindMax(20, 300, 50);
            findMax.FindMax(20.08, 300.00, 50.365);
            //Max With First Number.
            findMinMax.FindMax(2000, 300, 50);
            findMax.FindMax(20.08, 30.00, 500.365);
            //Max With Third Number.
            findMinMax.FindMax(2000, 300, 5000);
            findMax.FindMax(200.08, 3.00, 50.365);
            //Using Normal Method.
            findMinMax.MaxFind(20,30,50);

        }
    }
}