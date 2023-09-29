using System;

class Program
{
    static void Main()
    {
        // Создаем объект Random для генерации случайного числа
        Random random = new Random();

        // Генерируем случайное число от 1 до 100
        int secretNumber = random.Next(1, 101);

        int attempts = 0;
        int guess = 0;

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Попробуйте угадать число от 1 до 100.");

        while (guess != secretNumber)
        {
            attempts++;

            // Считываем введенное пользователем число
            Console.Write("Введите вашу догадку: ");
            string input = Console.ReadLine();

            // Пытаемся преобразовать введенную строку в число
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 100.");
                continue;
            }

            // Проверяем, является ли введенное число правильным
            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Число должно быть в диапазоне от 1 до 100.");
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
            else
            {
                Console.WriteLine($"Поздравляем! Вы угадали число {secretNumber} за {attempts} попыток.");
            }
        }

        Console.WriteLine("Игра окончена. Нажмите любую клавишу, чтобы выйти.");
        Console.ReadKey();
    }
}
