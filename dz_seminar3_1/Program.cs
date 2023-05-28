// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num / 1000 == num % 100)
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}