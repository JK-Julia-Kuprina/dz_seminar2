// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int Prompt(string message)
{
    System.Console.Write(message);
    string ReadInput = System.Console.ReadLine();
    int result = Convert.ToInt32(ReadInput);
    return result; 
}
int[] FillArray(int Length, int minGigit, int maxDigit)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minGigit, maxDigit + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("]");
}


int Length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для случайного числа: ");
int max = Prompt("Масимальное значение для случайного числа: ");
int[] array = FillArray(Length, min, max);
PrintArray(array);




