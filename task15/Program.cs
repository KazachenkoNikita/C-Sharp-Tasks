/*
15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    System.Console.WriteLine("Ошибка");
}
if (number > 0 && number < 6)
{
    System.Console.WriteLine("Не выходной день");
}
if (number == 6 || number == 7)
{
    System.Console.WriteLine("Выходной день");
}