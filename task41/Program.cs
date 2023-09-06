/* 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();

System.Console.WriteLine("Введи желаемое кол-во чисел М: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetUserArray(arrayLength);

int[] GetUserArray(int arrayLength)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Введи значение {i + 1} элемента: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int CountNumbersGreaterZero(int[] userArray)
{
    int count = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i] > 0) count++;
    }
    return count;
}

PrintArray(userArray);
System.Console.WriteLine($"Вы ввели {CountNumbersGreaterZero(userArray)} чисел больше 0");

