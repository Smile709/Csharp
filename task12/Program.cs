/* Напишите программу, которая которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. Если второе число не кратно первому, то программа выводит остаток от диления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/
Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number1 % number2;

if (result == 0)
{
    Console.WriteLine($"Число {number1} кратно {number2}");
}
else
{
    Console.WriteLine($"Число {number1} не кратно {number2} Остаток равен {result}");
}

