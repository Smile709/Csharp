/* 39. Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на 
последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
Комментарий: эту задачу можно решить 2 способами:
1) менять числа местами в исходном массиве;
2) создать новый массив и в него записать перевёрнутый исходный 
массив по элементам.
*/
Console.Clear();

System.Console.WriteLine("Введи кол-во элементов массива: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи Мин значение элементов массива: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи Макс значение элементов массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray(int arrayL, int min, int max)
{
    int[] array = new int[arrayL];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

int[] TurnArray(int[] arrayToTurn)
{
    int temp = 0;
    for (int i = 0; i < arrayToTurn.Length / 2; i++)
    {
        temp = arrayToTurn[i];
        arrayToTurn[i] = arrayToTurn[arrayToTurn.Length - i - 1];
        arrayToTurn[arrayToTurn.Length - i - 1] = temp;
    }
    return arrayToTurn;
}

int[] userArray = GetRandomArray(arrayL, min, max);
Console.ForegroundColor = ConsoleColor.Blue;
PrintArray(userArray);
Console.WriteLine();
int[] turnArray = TurnArray(userArray);
Console.ForegroundColor = ConsoleColor.Red;
PrintArray(turnArray);
Console.ForegroundColor = ConsoleColor.White;