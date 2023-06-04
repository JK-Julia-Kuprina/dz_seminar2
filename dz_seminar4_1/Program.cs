//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Math.Pow юзать нельзя.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

System.Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе целое число");
int exponent = Convert.ToInt32(Console.ReadLine());


int Res(int num, int exponent)
{
    int result = 1;
    for (int i = 0; i < exponent; i++)
    {
        result *= num;
    }
    return result;
}

bool VarExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Нельзя вводить число меньше нуля");
        return false;
    }
    return true;
}


if (VarExponent(exponent))
{
    System.Console.WriteLine($"Ваше число {num} возведенное в степень {exponent} равно {Res(num, exponent)}");
}