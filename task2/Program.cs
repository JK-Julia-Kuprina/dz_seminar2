﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    System.Console.WriteLine("третьей цифры нет");
}
else
{
    while (num > 1000)
    {
        num /=  10;
    }
    System.Console.WriteLine(num % 10);
}


