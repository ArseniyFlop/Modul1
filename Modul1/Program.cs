using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите задачу:");
            Console.WriteLine("1. Угадать число от 1 до 100");
            Console.WriteLine("2. Найти среднее арифметическое из 3 чисел");
            Console.WriteLine("3. Определить, является ли вторая строка подстрокой первой строки");
            Console.WriteLine("4. Найти сумму 10 случайных элементов массива");
            Console.WriteLine("5. FizzBuzz");
            Console.WriteLine("0. Выйти из программы");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Вы выбрали задачу 1.");
                    Program program = new Program();
                    program.Chislo();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали задачу 2.");
                    Program program1 = new Program();
                    program1.Arifm();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали задачу 3.");
                    Program program2 = new Program();
                    program2.Podstr();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("Вы выбрали задачу 4.");
                    Program program3 = new Program();
                    program3.SumM();
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("Вы выбрали задачу 5.");
                    Program program4 = new Program();
                    program4.FizBuzz();
                    Console.Clear();
                    break;
                case 0:
                    Console.WriteLine("Программа завершена.");
                    return;
                default:
                    Console.WriteLine("Некорректный выбор. Пожалуйста, выберите задачу из списка.");
                    break;
            }
        }
    }
    void Chislo()
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
    void Arifm()
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
    void Podstr()
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
    void SumM()
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
    void FizBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Нажмите любую клавишу, чтобы выйти.");
        Console.ReadKey();
    }
}
