/*
31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.
*/

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}
void ElementsSumOfArray(int[] arr1)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if(arr1[i] > 0)
        {
            sumPositive = sumPositive + arr1[i];
        }
        else
        {
            sumNegative = sumNegative + arr1[i];
        }
    }
    System.Console.WriteLine($"Сумма положительных элементов массива равна {sumPositive}");
    System.Console.WriteLine($"Сумма отрицательных элементов массива равна {sumNegative}");
}
int[] userArray = GetArray(12);
PrintArray(userArray);
ElementsSumOfArray(userArray);
