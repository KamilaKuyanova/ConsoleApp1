using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        if (double.TryParse(Console.ReadLine(), out double number))
        {
            if (number > 7)
            {
                Console.WriteLine("Привет");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
            return;
        }

        Console.Write("Введите имя: ");
        string name = Console.ReadLine().Trim();
        if (name == "John")
        {
            Console.WriteLine("Привет, John");
        }
        else
        {
            Console.WriteLine("Такого имени нет");
        }

        Console.Write("Введите массив чисел через пробел: ");
        string input = Console.ReadLine();
        try
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            var multiplesOfThree = array.Where(x => x % 3 == 0).ToArray();

            Console.WriteLine("Элементы массива, кратные 3: " + string.Join(", ", multiplesOfThree));
        }
        catch
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }
}