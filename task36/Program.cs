/*
36. Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел 
и выводит результат на экран.
*/
int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + "\t");
    }
    System.Console.WriteLine();
}
int SumOddElements(int[] arr1)
{
    int sum = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += arr1[i];
        }
    }
    System.Console.WriteLine($"Сумма нечётных элементов: {sum}");
    return sum;
}
int[] userArray = GetArray(10);
PrintArray(userArray);
SumOddElements(userArray);
