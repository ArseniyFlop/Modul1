using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите три числа для вычисления среднего арифметического.");

        // Считываем три числа из консоли
        Console.Write("Введите первое число: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double number2 = double.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        double number3 = double.Parse(Console.ReadLine());

        // Вычисляем среднее арифметическое
        double average = (number1 + number2 + number3) / 3;

        // Выводим результат
        Console.WriteLine($"Среднее арифметическое чисел {number1}, {number2} и {number3} равно {average}");

        Console.WriteLine("Нажмите любую клавишу, чтобы выйти.");
        Console.ReadKey();
    }
}
