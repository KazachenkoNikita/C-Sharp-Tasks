/*
34. Напишите программу, которая подсчитывает количество четных элементов 
в массиве целых положительных трехзначных чисел и выводит результат на экран.
*/
int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
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
int CountEvenElements(int[] arr1)
{
    int numberOfEvenElements = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] % 2 == 0)
        {
            numberOfEvenElements += 1;
        }
    }
    System.Console.WriteLine($"Количество чётных элементов: {numberOfEvenElements}");
    return numberOfEvenElements;
}
int[] userArray = GetArray(10);
PrintArray(userArray);
CountEvenElements(userArray);
