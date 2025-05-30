using System;
namespace HomeworkArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько элементов в массиве вы хотите ? ");
            Console.WriteLine();
            int size = int.Parse(Console.ReadLine());
            int[] number = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Введите число для элемента " + i + " : ");
                number[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(number);

            foreach (int num in number)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\nЧётные числа:");
            foreach (int num in number)
            {
                if (num % 2 == 0)
                    Console.Write(num + " ");
            }
            Console.WriteLine("\nНечётные числа:");
            foreach (int num in number)
            {
                if (num % 2 != 0)
                    Console.Write(num + " ");
            }

        }
    }
}
