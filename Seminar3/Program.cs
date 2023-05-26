// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void CheckKoord(int num) // что-то делает, но ничего не возвращает
{
    if (num == 1)
        System.Console.WriteLine("x > 0 && y > 0");
    else if (num == 2)
        System.Console.WriteLine("x < 0 && y > 0");
    else if (num == 3)
        System.Console.WriteLine("x < 0 && y < 0");
    else if (num == 4)
        System.Console.WriteLine("x < 0 && y < 0");
    else
        System.Console.WriteLine("Такой четверти нет");
}

string CheckKoord2(int num) // что-то делает, и что-то возвращает
{
    string result = "";
    if (num == 1)
        result = "x > 0 && y > 0";
    else if (num == 2)
        result = "x < 0 && y > 0";
    else if (num == 3)
        result = "x < 0 && y < 0";
    else if (num == 4)
        result = "x < 0 && y < 0";
    // else
    //     result=0;
    return result;
}


Console.Clear();
System.Console.WriteLine("Введите номер четверти");
int x = Convert.ToInt32(Console.ReadLine());


CheckKoord(x);
System.Console.WriteLine($" {CheckKoord2(x)}");

// int y = Convert.ToInt32(Console.ReadLine());
// if (x>0 && y>0)
//     System.Console.WriteLine("Это четверть № 1");
// else if (x>0 && y<0)
//     System.Console.WriteLine("Это четверть № 4");
// else if (x<0 && y<0)
//     System.Console.WriteLine("Это четверть № 3");
// else if (x<0 && y>0)
//     System.Console.WriteLine("Это четверть № 2");
// else 
//     System.Console.WriteLine("Точка находится на координатной оси");