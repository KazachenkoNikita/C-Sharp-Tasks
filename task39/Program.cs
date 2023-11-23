/*
39. Напишите программу, которя перевернёт одномерный массив.
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
void Reverse(int[] arr1)
{
    for (int i = 0; i < arr1.Length / 2; i++)
    {
        int temp = arr1[i];
        arr1[i] = arr1[arr1.Length - 1 - i];
        arr1[arr1.Length - 1 - i] = temp;
    }
}
int[] userArray = GetArray(10);
PrintArray(userArray);
Reverse(userArray);
System.Console.WriteLine();
PrintArray(userArray);