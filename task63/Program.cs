/*
63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/
void Digit (int max, int start = 1)
{
    if (start > max)
    {
        return;
    }
    else
    {
        System.Console.Write(start + " ");
        Digit (max, start + 1);
    }
}
Digit(5);
