// See https://aka.ms/new-console-template for more information
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
System.Console.WriteLine("Введите Ax");
int Ax = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Ay");
int Ay= int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Az");
int Az= int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Bx");
int Bx = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите By");
int By = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Bz");
int Bz = int.Parse(Console.ReadLine());
double sqrt = Math.Sqrt(Math.Pow(Ax-Bx,2)+Math.Pow(Ay-By,2)+Math.Pow(Az-Bz,2));
Console.WriteLine($"sqrt={sqrt:f2}");
