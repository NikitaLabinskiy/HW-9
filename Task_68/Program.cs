﻿// Задача 68: Напишите метод вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.Write("Введите число m: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
Console.Write("Введите число n: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);

int result = Akk(n, m);

Console.Write(result);

int Akk(int n, int m)
{
    if (n == 0)
    {
        return m + 1;  
    }
    else
    {
        if ((n != 0) && (m == 0))
        {
            return Akk(n - 1, 1);
        }
        else
        {
            return Akk(n - 1, Akk(n, m - 1));
        }
    }
}