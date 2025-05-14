using System;
namespace HomeworkArray
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
            Console.WriteLine("Вы ввели массив : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(number[i] + " ");
            }
        }
    }
}
