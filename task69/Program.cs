/*
69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
*/
double Styepen(int digit, int square)
{
    if (square == 1)
    {
        return digit;
    }
    else
    {
        return Math.Pow(digit, square); //digit * Styepen(digit, square - 1);
    }
}
double result = Styepen(2, 7);
System.Console.WriteLine(result);