/*
25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

System.Console.WriteLine("Введите числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine()); 
int Method(int number1, int number2)
{
    int usernum = 1;
    for (int i = 0; i < number2; i++)
    {
        usernum *= number1;
    }
    return usernum;
}
System.Console.WriteLine(Method(number1, number2));
