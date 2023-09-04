/* 38: Задайте массив вещественных чисел. Найдите разницу между
максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

System.Console.Clear();

/*System.Console.WriteLine("Введите количество элементов массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальное число которое может быть в массиве: ");
double minNumberArray = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное число которое может быть в массиве: ");
double maxNumberArray = Convert.ToInt32(Console.ReadLine());*/
double[]userArray = GetRandomArray(5, -20, 20);/*(arrayLength, minNumberArray, maxNumberArray);*/

double[] GetRandomArray(int arrayLength, double minNumberArray, double maxNumberArray)
{
    double[] array = new double[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()*(maxNumberArray-minNumberArray)-minNumberArray;
    }
    return array;
}

void PrintArray(double[] arrayToPrint)
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

// сортируем по убыванию и от первого отнимаем последний
void PrintDiffMaxMinElement(double[] arrayForDiff)
{
    /*for (int i = 0; i < arrayForDiff.Length - 1; i++)
    {
        for (int j = 0; j < arrayForDiff.Length - i - 1; j++)
        {
            if (arrayForDiff[j] < arrayForDiff[j+1]))
            {
                double temp = arrayForDiff[j];
                arrayForDiff[j] = arrayForDiff[j+1];
                arrayForDiff[j+1] = temp;
            }
        }
    }
    System.Console.WriteLine(Math.Round(arrayForDiff[0]-arrayForDiff[arrayForDiff.Length-1], 2));*/

    // просто находим мин и макс
    double max = arrayForDiff[0];
    double min = arrayForDiff[0];
    for (int i = 1; i < arrayForDiff.Length; i++)
    {
        if (max < arrayForDiff[i]) max = arrayForDiff[i];
        else if (min>arrayForDiff[i]) min = arrayForDiff[i];
    }
    System.Console.WriteLine(Math.Round(max-min, 2));
}

PrintArray(userArray);
PrintDiffMaxMinElement(userArray);