//Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные,
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

void Change1(int[] array)
{

    for (int i = 0; i < array.Length; i++) array[i] = - array[i];

}
int[] array = new int[12];
FillArray(array);
PrintArray(array);
Change1(array);
PrintArray(array);
