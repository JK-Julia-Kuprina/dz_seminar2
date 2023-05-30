// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


int Factorial (int num)
{
    int result = 1;
    for (int i=1; i<=num; i++)
        result = i * result;
    return result;
}

System.Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Произведение всех чисел от 1 до {num} равна {Factorial(num)}");

