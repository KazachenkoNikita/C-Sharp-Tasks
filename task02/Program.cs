/*
2. Найдите большее из двух чисел.
*/

System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
  System.Console.WriteLine("Первое число больше, чем второе");
}
else if (number2 > number1)
{
  System.Console.WriteLine("Второе число больше, чем первое");
}
else
{
  System.Console.WriteLine("Введенные числа равны");
}
