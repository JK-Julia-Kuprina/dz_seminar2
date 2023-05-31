// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

int a = num / 10000; int b = num / 1000 % 10; int d = num / 10 % 10; int e = num % 10;


if (a == e & b == d)
{
    System.Console.WriteLine("yes");
} 
else
{
    System.Console.WriteLine("no");
}




        
