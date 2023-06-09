﻿// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали
// для него программу, по которой робот, когда заходит в комнату, считает количество программистов в ней и
// произносит его вслух: "n программистов".
// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное),
// выводящее это число в консоль вместе с правильным образом изменённым словом "программист", 
// для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает
// все случаи, как минимум до 1000 человек.

System.Console.WriteLine("вводим n программистов в комнате");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 11 || n % 100 == 11 ||
    n == 12 || n % 100 == 12 ||
    n == 13 || n % 100 == 13 ||
    n == 14 || n % 100 == 14)
{
    System.Console.WriteLine($"{n} программистов");
}
else if(n % 10 == 2 || n % 10 == 3 || n % 10 == 4)
{
      System.Console.WriteLine($"{n} программиста");
}
else
{
    System.Console.WriteLine($"{n} программист");
}