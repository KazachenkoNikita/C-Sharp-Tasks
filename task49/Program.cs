/*
49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
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
int[,] EvenElementsKvadrat(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if(i%2 == 0 && j%2 == 0) arr1[i, j] = arr1[i, j] * arr1[i, j];
        }
    }
    return arr1;
}
int[,] ArrayMatrix = GetRnd(3, 3);
PrintMatrix(ArrayMatrix);
int[,] SecondArray = EvenElementsKvadrat(ArrayMatrix);
System.Console.WriteLine();
PrintMatrix(SecondArray);