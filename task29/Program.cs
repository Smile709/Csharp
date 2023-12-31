﻿/*29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

System.Console.WriteLine("Введите количество элементов массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальное число которое может быть в массиве: ");
int minNumberArray = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное число которое может быть в массиве: ");
int maxNumberArray = Convert.ToInt32(Console.ReadLine());
int[] GetRandomArray(int arrLength, int minNumArray, int maxNumArray)
{
    int[] array = new int[arrLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minNumArray, maxNumArray);

    }
    return array;
}

int[] userArray = GetRandomArray(arrayLength, minNumberArray, maxNumberArray);

void PrintArray(int[] arrayToPrint)
{
    System.Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        System.Console.Write(arrayToPrint[i]); 
        if (i<arrayToPrint.Length-1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.WriteLine("]");
}

PrintArray(userArray);