// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

                               // A(m, n) = при m = 0; n+1
                               // A(m, n) = при n = 0; A(m - 1, 1)
int accerman(int m, int n)     // A(m, n) = при m и n > 0; A(m - 1, A(m, n-1))
{
    if (m == 0) return n + 1;
    else if (n == 0) return accerman(m - 1, 1);
    else return accerman(m - 1, accerman(m, n - 1));
}

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

System.Console.WriteLine(accerman(m, n));
