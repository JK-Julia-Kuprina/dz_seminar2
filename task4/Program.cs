// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева целой части этого числа.

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

System.Console.WriteLine("введите целое или вещественное число число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию");
int s = Convert.ToInt32(Console.ReadLine());
int m = 1;
while (s > 1) {
     m *= 10;
     s--;
}
double t = (num % m) + (num / (m * 10)) * m;
Console.WriteLine(t);
// удаляет позицию из конкретного целого числа от макс разряда к первому