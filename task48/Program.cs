/*
48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m + n. 
Выведите полученный массив на экран.
*/
int[,] arr = CreateArray(5,5);
PrintMatrix(arr);
int[,] CreateArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
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
