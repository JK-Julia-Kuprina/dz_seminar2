// Задача 33: Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да 

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

bool FindNum(int[] array, int num)
{
    bool numPresent = false;
    for (int i = 0; i < array.Length; i++)
        if (array[i] == num)
        {
            numPresent = true;
            break;
        }
    return numPresent;
}

void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}


int[] array = new int[50];
System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

FillArray(array);
PrintArray(array);
System.Console.WriteLine(FindNum(array, num));