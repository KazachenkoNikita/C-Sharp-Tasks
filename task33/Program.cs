/*
33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

*/

/*int[] arr = {6, 7, 19, 345, 3};
Print(arr);
System.Console.WriteLine("Введите число: ");
int num = int.Parse(System.Console.ReadLine());
*/

bool isExist(int[] array, int target)
{
    foreach(int element in array)
    {
        if (element == target) return true;
        {
            return false;
        }
    }
}
