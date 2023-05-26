// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева целой части этого числа.

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

System.Console.WriteLine("введите целое или вещественное число число");
double num = Convert.ToDouble(Console.ReadLine());

if (num < 10)
{
    System.Console.WriteLine("второй цифры нет");
}
else
{
    while (num > 100)
    {
        num /= 10;
    }
    System.Console.WriteLine(num / 10 % 10);
}
