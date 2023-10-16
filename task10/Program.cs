/*
10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

System.Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number % 10;
int number3 = (number - number2)/10;
int number4 = number3 % 10;
if (number < 100 || number > 999)
{
    System.Console.WriteLine("Ошибка. Введите трёхзначное число");
}
else
{
    System.Console.WriteLine(number4);
}
