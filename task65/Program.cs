/*
65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
*/
void Digit (int n, int m)
{
    if (m > n)
    {
        return;
    }
    else
    {
        System.Console.Write(m + " ");
        Digit (n, m + 1);
    }
}
Digit(15, 7);
