/*50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
System.Console.WriteLine("Введи № строки желаемого элемента: ");
int rowDesiredNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи № столбца желаемого элемента: ");
int columnDesiredNum = Convert.ToInt32(Console.ReadLine());

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

void FindDesiredNum(int[,] userArray, int rowDesNum, int colDesNum)
{
    if (rowDesNum < userArray.GetLength(0) && colDesNum < userArray.GetLength(1)) 
    {
        Console.WriteLine($"Значение элемента из {rowDesNum} строки {colDesNum}-го столбца: {userArray[rowDesNum, colDesNum]}");
    }    
    else Console.WriteLine($"Элемента с № строки {rowDesNum} и № столбца {colDesNum} не существует");
}

int[,] randomArray = GetRandom2DArray(rows, columns, minNum, maxNum);
Print2DArray(randomArray);
FindDesiredNum(randomArray, rowDesiredNum, columnDesiredNum);