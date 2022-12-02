// Задача 66: Задайте значения M и N. 
// Напишите метод, который найдёт сумму натуральных элементов в промежутке от M до N. 
// Через рекурсию!
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите число m: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите число n: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

int number = SumOfDigitsBetweenNumbers(m, n);

Console.Write(number);

int SumOfDigitsBetweenNumbers(int number1, int number2)
{
    int digit = 0;
    if (number1 <= number2)
    {
        int temp = number1;
        digit += temp;
        digit += SumOfDigitsBetweenNumbers(number1 + 1, number2);
    }
    return digit;
}