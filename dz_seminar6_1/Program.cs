// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int PositivNumber(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    count++;   
}
return count;
}

Console.Clear();

System.Console.Write("Введите некоторое колличество чисел через пробел ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

PrintArray(array);
PositivNumber(array);
int count = PositivNumber(array);

System.Console.WriteLine(PositivNumber(array));
