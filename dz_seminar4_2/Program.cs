﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Sum (int num)
{
    int result = 0;
   while (num > 0)
   {
        result += num % 10;
        num = num / 10;
   }
    return result;
}

System.Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Сумма всех цифр в числе {num} равна {Sum(num)}");