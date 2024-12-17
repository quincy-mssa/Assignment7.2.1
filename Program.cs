namespace Assignment7._2._1
{
    //Implement shell sort on an unsorted array of numbers. Take the array input from user.

    internal class Program
    {
        //shell sort method
        static void Sort(int[] a)
        {
            for (int h = a.Length / 2; h > 0; h /= 2)
            {
                for (int i = h; i < a.Length; i++)
                {
                    int j = i;
                    int ai = a[i];
                    while (j >= h && a[j - h] > ai)
                    {
                        a[j] = a[j - h];
                        j -= h;
                    }
                    a[j] = ai;
                }
            }
        }

        static void Main(string[] args)
        {
            //hard-coded array
            int[] array = { 8, 4, 12, 5, 13, 22 };

            Console.WriteLine("Unsorted array:");
            Console.WriteLine(string.Join(" ", array));

            //call sort method
            Sort(array);

            Console.WriteLine("Sorted array using shell sort:");
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
