// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("введите координату xa"); //AB = √(xb - xa) * 2 + (yb - ya) * 2 + (zb - za) * 2
double xa = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("введите координату ya");
double ya = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("введите координату za");
double za = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("введите координату xb");
double xb = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("введите координату yb");
double yb = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("введите координату zb"); // A(0, -3, 3) и B(3, 1, 3). A(xa, ya, za); B(xb, yb, zb)
double zb = Convert.ToDouble(Console.ReadLine());

double S = Math.Sqrt(((xb - xa) * (xb - xa)) + ((yb - ya) * (yb - ya)) + ((zb - za) * (zb - za)));
System.Console.WriteLine(S);