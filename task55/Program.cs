/*
55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
Если это невозможно, программа должна вывести сообщение для пользователя.
*/
int[,] GetRnd(int rows, int colom)
{
    int[,] array = new int[rows, colom];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
int[,] Swaped(int[,] arr)
{
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        System.Console.WriteLine("Заменить строки и столбцы невозможно");
        return arr;
    }
    int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[i, j] = arr[j, i];
        }
    }
    return result;
}
void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int[,] randomArray = GetRnd(3, 3);
PrintMatrix(randomArray);
int [,] swapedArray = Swaped(randomArray);
System.Console.WriteLine();
PrintMatrix(swapedArray);
