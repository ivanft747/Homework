using System;
using System.IO;
using System.Linq;
using System.Xml;
namespace HomeworkRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите высоту прямоугольника");
                int height = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите длинну прямоугольника");
                int width = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                for (int i = 0;i < height; i++)
                {
                    for (int j = 0;j < width; j++)
                    {
                        Console.Write("O");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("");
            }
        }
    }
}
