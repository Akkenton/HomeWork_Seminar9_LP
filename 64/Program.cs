﻿// **Задача 64**: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"  
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int ReverseRecurentN(int N)
{
    if (N == 1) return N;
    else
    {
        System.Console.Write($"{N}, ");
        N--;
        return ReverseRecurentN(N);
    }
}

Console.Clear();
int N = 8;
System.Console.Write("'");
System.Console.Write(ReverseRecurentN(N));
System.Console.Write("'");