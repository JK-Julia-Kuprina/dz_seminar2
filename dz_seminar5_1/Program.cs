//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"{item }");
    System.Console.WriteLine();
    }
}

int EvenNumber(int[] array)
{
    int Even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        Even++;
    }
return Even;    
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
EvenNumber(array);
System.Console.WriteLine(EvenNumber(array));