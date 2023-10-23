/*
21. Напишите программу, которая принимает на вход координаты двух точек в виде массива целых чисел, 
и возвращает расстояние между ними в 3D пространстве. 
*/

System.Console.Write("Введите значение оси X для точки A: ");
double aX = double.Parse(Console.ReadLine());
System.Console.Write("Введите значение оси Y для точки A: ");
double aY = double.Parse(Console.ReadLine());
System.Console.Write("Введите значение оси Z для точки A: ");
double aZ = double.Parse(Console.ReadLine());
System.Console.Write("Введите значение оси X для точки B: ");
double bX = double.Parse(Console.ReadLine());
System.Console.Write("Введите значение оси Y для точки B: ");
double bY = double.Parse(Console.ReadLine());
System.Console.Write("Введите значение оси Z для точки A: ");
double bZ = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((bX - aX), 2d) + (Math.Pow((bY - aY), 2d) + (Math.Pow((bZ - aZ), 2d))));
System.Console.WriteLine("Расстояние между точками: " + Math.Round(result, 3));