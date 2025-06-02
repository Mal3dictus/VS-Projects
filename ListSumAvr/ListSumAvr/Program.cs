using System;

namespace ListSumAvr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input List: ");
            string[] input = Console.ReadLine().Split(' ');
            int[] List = Array.ConvertAll(input, int.Parse);
            int sum = List.Sum();
            double average = List.Average();
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");


        }
    }
}

