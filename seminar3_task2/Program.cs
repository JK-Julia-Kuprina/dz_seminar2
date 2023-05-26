// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
System.Console.WriteLine("введите координату x1"); //AB = √(xb - xa)2 + (yb - ya)
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("введите координату x2");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("введите координату y2");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("введите координату y2");
double y2 = Convert.ToDouble(Console.ReadLine());


  double d = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
    System.Console.WriteLine(d);
