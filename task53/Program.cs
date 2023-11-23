/*
53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/
int[,] array = {{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}, {13, 14, 15, 16}};
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();
ArraySwapRows(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    System.Console.WriteLine();
}

void ArraySwapRows(int[,] arr)
{
    int[] temp = new int[arr.GetLength(1)];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
    }
    for (int i = 0; i < temp.Length; i++)
    {
        arr[arr.GetLength(0) - 1, i] = temp[i];
    }
}