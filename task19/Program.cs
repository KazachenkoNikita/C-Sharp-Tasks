/*
19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

System.Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = number1 % 10; // Пятый остаток от первого числа.
int number3 = (number1 - number2) / 10; // Число стало четырёхзначным.
int number4 = number3 % 10; // Четвёртый остаток от первого числа.
int number5 = (number3 - number4) / 10; // Число стало трёхзначным.
int number6 = number5 % 10; // Третий остаток от первого числа.
int number7 = (number5 - number6) / 10; // Число стало двухзначным.
int number8 = number7 % 10; // Второй остаток от первого числа.
int number9 = (number7 - number8) / 10; // В первом числе осталась первая цифра.
int number10 = (number2 * 10000) + (number4 * 1000) + (number6 * 100) + (number8 * 10) + number9; // Полученный палиндром.
if (number1 < 10000 || number1 > 99999)
{
    System.Console.WriteLine($"{number1} -> Число не пятизначное");
    System.Console.WriteLine("\t" + "\t" + "False");
}
else if (number10 != number1)
{
 System.Console.WriteLine($"{number1} -> False");
}
else if (number10 == number1)
{
 System.Console.WriteLine($"{number1} -> True");
}
