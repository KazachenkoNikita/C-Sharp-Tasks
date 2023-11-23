/*
64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
*/
void CountNumbersInReverse(int n, int m)
{
    if (m < n)
    {
        return;
    }
    else
    {
        System.Console.Write(m + " ");
        CountNumbersInReverse(n, m - 1);
    }
}
CountNumbersInReverse(1, 5);
