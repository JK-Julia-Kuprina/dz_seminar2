Console.WriteLine("Введите колличество программистов");
int programmers = Convert.ToInt32(Console.ReadLine());

if (programmers == 11 || programmers % 100 == 11 ||
    programmers == 12 || programmers % 100 == 12 ||
    programmers == 13 || programmers % 100 == 13 ||
    programmers == 14 || programmers % 100 == 14)
{
    System.Console.WriteLine($"{programmers} программистов");
}

else if (programmers % 10 == 1)
{
    System.Console.WriteLine($"{programmers} программист");
}

else if (programmers % 10 == 2 || programmers % 10 == 3 || programmers % 10 == 4)
{
    System.Console.WriteLine($"{programmers} программиста");
}

else
{
    System.Console.WriteLine($"{programmers} программистов");
}
