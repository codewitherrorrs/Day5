namespace Day5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FindMinMax<int> findMinMax = new FindMinMax<int>();
            //Max With Second Number.
            findMinMax.FindMax(20, 300, 50);
            //Max With First Number.
            findMinMax.FindMax(2000, 300, 50);
            //Max With Third Number.
            findMinMax.FindMax(2000, 300, 5000);

        }
    }
}