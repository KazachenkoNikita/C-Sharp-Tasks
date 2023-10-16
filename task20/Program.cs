/*
20. Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

System.Console.Write("Введите значение оси X для точки A: ");
double aX = double.Parse(Console.ReadLine());
System.Console.Write("Введите значение оси Y для точки A: ");
double aY = double.Parse(Console.ReadLine());
System.Console.Write("Введите значение оси X для точки B: ");
double bX = double.Parse(Console.ReadLine());
System.Console.Write("Введите значение оси Y для точки B: ");
double bY = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((bX - aX), 2d) + (Math.Pow((bY - aY), 2d)));
System.Console.WriteLine("Расстояние между точками: " + Math.Round(result, 3));
