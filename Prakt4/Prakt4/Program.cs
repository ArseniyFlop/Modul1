using System;

class Program
{
    static void Main()
    {
        // Создаем объект Random для генерации случайных чисел
        Random random = new Random();

        // Создаем массив из 10 целых чисел
        int[] numbers = new int[10];

        // Заполняем массив случайными числами и считаем их сумму
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101); // Генерируем случайное число от 1 до 100
            sum += numbers[i];
        }

        // Выводим элементы массива
        Console.WriteLine("Элементы массива:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        // Выводим сумму элементов массива
        Console.WriteLine("\nСумма элементов массива: " + sum);

        Console.WriteLine("Нажмите любую клавишу, чтобы выйти.");
        Console.ReadKey();
    }
}
