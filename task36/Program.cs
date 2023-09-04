/* 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

System.Console.Clear();

System.Console.WriteLine("Введите количество элементов массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальное число которое может быть в массиве: ");
int minNumberArray = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное число которое может быть в массиве: ");
int maxNumberArray = Convert.ToInt32(Console.ReadLine());
int[]userArray = GetRandomArray(arrayLength, minNumberArray, maxNumberArray);

int[] GetRandomArray(int arrayLength, int start, int end)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

void PrintSumOddElements(int[] arrayForSum)
{
    int sumOdd = 0;
    for (int i = 1; i < arrayForSum.Length; i += 2)
    {
        sumOdd += arrayForSum[i];
    }
    System.Console.WriteLine($"Сумма элементов стоящих на нечётных позициях = {sumOdd}");
}

PrintArray(userArray);
PrintSumOddElements(userArray);
