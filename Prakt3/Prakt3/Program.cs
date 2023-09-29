using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первую строку:");
        string firstString = Console.ReadLine();

        Console.WriteLine("Введите вторую строку:");
        string secondString = Console.ReadLine();

        // Проверяем, является ли вторая строка подстрокой первой строки
        if (firstString.Contains(secondString))
        {
            Console.WriteLine("Вторая строка является подстрокой первой строки.");
        }
        else
        {
            Console.WriteLine("Вторая строка не является подстрокой первой строки.");
        }

        Console.WriteLine("Нажмите любую клавишу, чтобы выйти.");
        Console.ReadKey();
    }
}
