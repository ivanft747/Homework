using System;
using System.Linq;
namespace HomeworkArray10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько чисел в массиве?");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите число:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int max1 = numbers.Max();
            int min1 = numbers.Min();
            Console.WriteLine("1 решение:");
            Console.WriteLine("Максимум: " + max1);
            Console.WriteLine("Минимум: " + min1);
            Array.Sort(numbers);
            int min2 = numbers[0];
            int max2 = numbers[numbers.Length - 1];
            Console.WriteLine("2 решение:");
            Console.WriteLine("Максимум: " + max2);
            Console.WriteLine("Минимум: " + min2);
        }
    }
}
