// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());


if (num == 6 || num == 7)
{
    System.Console.WriteLine("это выходной");
}
else
{
    System.Console.WriteLine("рабочий день");
}
