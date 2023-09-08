/* 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

System.Console.WriteLine("Введи кол-во строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи кол-во столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи Мин значение элементов массива: ");
int minNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи Макс значение элементов массива: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

int[,] GetRandom2DArray(int rowNumber, int colNumber, int min, int max)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(min, max); ;
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
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
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[] ArithmeticOfColumn(int[,] array)
{ 
    double[] arrResult = new double[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result += array[j, i];
        }
        arrResult[i] = result / array.GetLength(1);
    }
    return arrResult;
}

void PrintArray(double[] arrayToPrint)
{
    Console.Write("[Avg]\t");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(Math.Round(arrayToPrint[i], 1));
        if (i < arrayToPrint.Length - 1) System.Console.Write("\t");
    }
}

int[,] array = GetRandom2DArray(rows, columns, minNum, maxNum);
double[] ArithmeticCol = ArithmeticOfColumn(array);
Print2DArray(array);
PrintArray(ArithmeticCol);