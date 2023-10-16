/*
8. Напишите программу, которая выведет все чётные числа от одного до N.
*/
System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= number; i+=2)
{
    System.Console.Write(i + "\t");
}
