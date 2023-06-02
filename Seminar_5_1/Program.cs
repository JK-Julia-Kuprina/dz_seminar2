// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные,
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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