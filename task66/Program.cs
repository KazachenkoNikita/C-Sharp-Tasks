/*
66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int Summ(int n, int m)
{
    if (m > n)
    {
        return 0;
    }
    else
    {
        return m + Summ(n, m + 1);
    }
}
int result = Summ(15, 1);
System.Console.WriteLine(result);