﻿// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());


int digital(int num)
{
    int count = 0;
    if (num == 0) count = 1;
    else
    {
        while (num != 0)
        {
            num = num / 10;
            count++;
        }
    }
    return count;
}
System.Console.WriteLine($"{digital(num)}");



