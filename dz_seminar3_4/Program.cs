// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в N-мерном пространстве. Сначала задается N с клавиатуры,
// потом задаются координаты точек.

// System.Console.WriteLine("Введите N, где N является N-мерным пространством");
// int N = int.Parse(Console.ReadLine());
// double[] p = new double[N];
// double[] q = new double[N];
// int count = 1;

// while (count <= N)
// {    
//     System.Console.WriteLine($"Введите координату p{count}");
//     p[i] = double.Parse(Console.ReadLine());    
//     System.Console.WriteLine($"Введите координату q{count}");
//     int q = Convert.ToInt32(Console.ReadLine());    
//     count++;
// }

// for (int i = 0; i < N; i++)
// {
//    p[i] = double.Parse(Console.ReadLine()); 
// }

// for (int i = 0; i < N; i++)
// {
//     q[i] = double.Parse(Console.ReadLine());
// }


// System.Console.WriteLine(S);
using System;

class Program
{    static void Main(string[] args)
    {
        Console.Write("Введите размерность пространства N: ");
        int n = int.Parse(Console.ReadLine()!);

        double[] point1 = new double[n];
        double[] point2 = new double[n];

        Console.WriteLine("Введите координаты первой точки:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Координата {i + 1}: ");
            point1[i] = double.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("Введите координаты второй точки:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Координата {i + 1}: ");
            point2[i] = double.Parse(Console.ReadLine()!);
        }

        double distance = CalculateDistance(point1, point2);
        Console.WriteLine($"Расстояние между точками: {distance}");
    }

    static double CalculateDistance(double[] point1, double[] point2)
    {
        double sum = 0;
        for (int i = 0; i < point1.Length; i++)
        {
            double diff = point1[i] - point2[i];
            sum += diff * diff;
        }

        return Math.Sqrt(sum);
    }
}






