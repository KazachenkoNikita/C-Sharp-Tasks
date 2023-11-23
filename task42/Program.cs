/*
42. Преобразование десятичного числа в двоичное.
*/
int value = 10;
System.Console.WriteLine(DecToBinary(value));
int DecToBinary(int num)
{
    int result = 0;
    int temp = 1;
    while(num > 0)
    {
        result += num % 2 * temp;
        num /= 2;
        temp *= 10;
    }
    return result;
}
