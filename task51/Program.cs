/* 51. Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/


Console.Clear();

int[,] GetRandom2DArray(int rowNumber, int colNumber, int min, int max)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int SumDiaganalArray(int[,] array)
{
    int result = 0;
    int cols = array.GetLength(0);
    int rows = array.GetLength(1);
    int size = cols;
    if (cols > rows) size = rows;
    for (int i = 0; i < size; i++)
    {
        result += array[i,i];
    }
    return result;
}

int[,] randomArray = GetRandom2DArray(5, 5, 0, 10);
Print2DArray(randomArray);
System.Console.WriteLine(SumDiaganalArray(randomArray));
