using System;
using System.Diagnostics;

namespace ShellSort
{
    internal class Program
    {
        public static void ShellSort(int[] array)
        {
            int n = array.Length;
            int gap = n / 2;
            while(gap>0)
            {
                for(int i=gap;i<n;i++)
                {
                    int temp = array[i];
                    int j = i;
                    while(j>=gap && array[j-gap]>temp)
                    {
                        array[j] = array[j - gap];
                        j -= gap;
                    }
                    array[j] = temp;
                }
                gap /= 2;
            }
            
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 7, 4, 5, 2, 45, 90, 67 };
            Console.WriteLine("Print Array without Sort");
            Print(arr);
            Stopwatch stopwatch = new Stopwatch();    //Adding a stpwatch
            stopwatch.Start();
            ShellSort(arr);
            stopwatch.Stop();
            Console.WriteLine("After Shell Sort");
            Print(arr);
            Console.WriteLine($"arraySize {arr.Length} Time Taken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();
        }
    }
}
