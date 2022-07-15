/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Write("Введите координаты точки A.X=");
double Ax=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки A.Y=");
double Ay=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки A.Z=");
double Az=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B.X=");
double Bx=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B.Y=");
double By=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B.Z=");
double Bz=Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((Ax-Bx),2)+Math.Pow((Ay-By),2)+Math.Pow((Az-Bz),2));
Console.WriteLine(distance);
