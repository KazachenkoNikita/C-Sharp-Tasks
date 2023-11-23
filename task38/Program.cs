/*
38. Разница между максимальным и минимальным элементами массива.
*/
double[] GetArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10) + new Random().NextDouble();
    }
    return array;
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write((Math.Round(arr[i], 2) + "\t"));
    }
    System.Console.WriteLine();
}
void MinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    System.Console.WriteLine($"Разница между {Math.Round(max, 2)} и {Math.Round(min, 2)} равна {Math.Round(max - min, 2)}");
}
double[] userArray = GetArray(10);
System.Console.WriteLine();
PrintArray(userArray);
MinMax(userArray);