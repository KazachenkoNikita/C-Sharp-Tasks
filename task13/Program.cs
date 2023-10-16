/*
13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/

int number = new Random().Next();
System.Console.WriteLine(number);
//int number2 = number % 10;

if(number < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
while(number >= 1000)
{
    number /= 10;
}
Console.WriteLine(number % 10);