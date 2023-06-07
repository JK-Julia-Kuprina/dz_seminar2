//  Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        double num = new Random().NextDouble() * 10;
        array[i] = num;
        Console.Write(array[i] + ". ");
        System.Console.WriteLine();
    }
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] > max) 
        {
            max = array[i];
        }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] < min)
        {
            min = array[i];
        }
    return min;
}

double[] array = new double[5];
FillArray(array);
Max(array);
Min(array);
System.Console.WriteLine($"максимальное значение в массиве: {Max(array)}");
System.Console.WriteLine($"Минимальное значение в массиве: {Min(array)}");
System.Console.WriteLine($"{Max(array) - Min(array)}:f1");

