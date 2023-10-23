/*Console.Clear();

int num = 6;
double Num(int a)
{
    double result = Math.Pow(a, 3);
    return result;
}

double usernum = Num(2);
System.Console.WriteLine(usernum);

int Num1()
{
    int a1 = 5;
    int result = a1 + a1;
    return result;
}

void Num2(int a2)
{
    int result = a2 + a2;
    System.Console.WriteLine(result);
}

int usera = Num1();
System.Console.WriteLine(usera);

Num2(2);
Num2(25);
int usera1 = Num1();
System.Console.WriteLine(usera1);
double usernum1 = Num(7);
System.Console.WriteLine(usernum1);
*/

/*24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int Numbers1(int numb)
{
    int sum = 0;
    for (int i = 0; i <= numb; i++)
    {
        sum = sum + i;
    }
    return sum;
}
System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = Numbers1(userNumber);
System.Console.WriteLine($"Сумма чисел от 1 до {userNumber} = {result}");

