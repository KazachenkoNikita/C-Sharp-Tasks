/*
27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Method(int num)
{
    int result = 0;
    for (int i = num; i > 0; i /= 10)
    {
        result += num % 10;
    }
    return result;
}
System.Console.WriteLine(Method(number));
