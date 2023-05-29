// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом.
//  Через строку нельзя решать само собой.

// System.Console.WriteLine("введите целое число");
// int num = int.Parse(Console.ReadLine());
// int l = num;
// var col = new List<int>();

// while (col > 0)
// {
//     col.Add(l % 10);
//     l = l / 10; 
// }
// l = 0;
// col.Reverse();
// for (int mcol = 0; mcol < col.Count; mcol++)
//     l = l + col[mcol] * (num)Math.Pow(10, mcol);
// if (num == l)
// {
//     System.Console.WriteLine("yes");
// }
// else
// {
//     System.Console.WriteLine("no");
// }
        

System.Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int revnum = 0;
int rem = num;

while (num > 0)
{
    rem = num % 10;
    revnum = revnum * 10 + rem;
    num = num / 10;
}
if (revnum == temp)
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}
System.Console.WriteLine();







// int rev = 0; // обратная сторона заданного числа


// while (num > 0)
//     {
//         int r = num % 10; // получаем последнюю цифру и сохраняем ее в r
//         rev = rev * 10 + r; // добавляем r к обратной стороне
//         num = num / 10; // убираем последнюю цифру
//     }
// return (num == rev);
// if (num == rev)
// {
//     System.Console.WriteLine("yes");
// }
// else
// {
//     System.Console.WriteLine("no");
// }
