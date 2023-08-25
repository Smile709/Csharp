/* 24. Напишите программу, которая принимает на вход число (А)
 и выдаёт сумму чисел от 1 до А.

*/

System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= userNumber; i++)
{
    sum += i;
}

System.Console.WriteLine(sum);
