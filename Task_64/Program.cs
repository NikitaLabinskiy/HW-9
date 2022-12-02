// Задача 64: Задайте значение N. 
// Напишите метод, который выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите число: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

AllNaturalNumbers(n);

void AllNaturalNumbers(int number)
{
    if (number > 0)
    {
        Console.Write($"{number--} ");
        AllNaturalNumbers(number);
    }
}

