/* 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень: ");
int userExp = Convert.ToInt32(Console.ReadLine());

int Exponentiation (int number)
{
    int exp = 1;
    for (int i = 1; i <= userExp; i++)
{
    exp *= userNumber;
}
    return exp;
}

Console.WriteLine($"Число {userNumber} в степени {userExp} равно {Exponentiation(userNumber)}");
