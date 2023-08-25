/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int usernumber = number;
int reversenumber = 0;
if (number < 0) number = number * -1;
if (number > 9999 && number < 100000)
{
    while (number > 0)
    {
        reversenumber *= 10;
        reversenumber += number % 10;
        number /= 10;
    }
    if (usernumber == reversenumber)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine($"Нет {reversenumber}");
    }
}
else
{ Console.WriteLine("Число не пятизначное"); }
