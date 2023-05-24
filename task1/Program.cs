// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1
System.Console.WriteLine("введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num >= 1000)
{
    System.Console.WriteLine("false");
    return;
}
System.Console.WriteLine(num / 10 % 10);

