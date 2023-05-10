namespace Day5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Delete Int array element.
            DeleteElement deleteElement = new DeleteElement();
            int[] arr = { 10, 20, 30, 40 };
            Console.WriteLine("Original Array : ");
            foreach(int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\nEnter the position : ");
            int position = int.Parse(Console.ReadLine());
            deleteElement.DeleteInt(arr,position);
          
            //For Char Dlelete.
            Console.WriteLine("Enter the string :");
            string value = Console.ReadLine();
            char[] arrOne = value.ToCharArray();
            Console.WriteLine("Original Array : ");
            foreach (char ch in arrOne)
            {
                Console.Write($"{ch} ");
            }
            Console.WriteLine("\nEnter the position : ");
            int positionOne = int.Parse(Console.ReadLine());
            deleteElement.DeleteChar(arrOne, positionOne);
            /*    FindMinMax<int> findMinMax = new FindMinMax<int>();
                FindMinMax<double> findMax = new FindMinMax<double>();
                FindMinMax<string> stringMax = new FindMinMax<string>();
                //Max With Second Number.
                findMinMax.FindMax(20, 300, 50);
                findMax.FindMax(20.08, 300.00, 50.365);
                stringMax.FindMax("Apple","Peach","Banana");
                //Max With First Number.
                findMinMax.FindMax(2000, 300, 50);
                findMax.FindMax(20.08, 30.00, 500.365);
                stringMax.FindMax("Orange", "Peach", "Banananan");
                //Max With Third Number.
                findMinMax.FindMax(2000, 300, 5000);
                findMax.FindMax(200.08, 3.00, 50.365);
                stringMax.FindMax("PineApple", "Peach", "Banana");
                //Using Normal Method.
                findMinMax.MaxFind(20,30,50);
            */
        }
    }
}