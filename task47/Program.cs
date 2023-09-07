/* 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();


double[,] GetRandom2DArray(int rowNumber, int colNumber, int min, int max)
{
    double[,] result = new double[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().NextDouble()*(max - min) + (min);
        }
    }
    return result;
}

void Print2DArray(double[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(Math.Round(arrayToPrint[i, j],1) + "\t");
        }
        Console.WriteLine();
    }
}

double[,] randomArray = GetRandom2DArray(5, 5, -10, 10);
Print2DArray(randomArray);
