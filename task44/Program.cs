/*
44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
*/
void Fibonachi(int numb)
{
    int[] fibonachi = new int [numb + 1];
    if (numb == 0) System.Console.WriteLine("1");
    else
    {
    for (int i = 0; i < 2; i++)
    {
        fibonachi[i] = i;
        System.Console.Write(fibonachi[i] + " ");
    }
    for (int i = 2; i < numb; i++)
    {
        fibonachi[i] = fibonachi[i - 2] + fibonachi[i - 1];
        System.Console.Write(fibonachi[i] + " ");
    }
    }
}
Fibonachi(7);
