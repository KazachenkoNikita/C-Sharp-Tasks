/*
6. Проверьте число на чётность.
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
    System.Console.WriteLine("Число чётное");
}
else
{
    System.Console.WriteLine("Число нечётное");
}
