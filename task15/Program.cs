/* 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

*/

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
    if (number > 0 && number < 6)
      Console.WriteLine("нет, это не выходной");
      else 
      Console.WriteLine("да, это выходной");
}
else
{
    Console.WriteLine("цифра, не обозначает день недели");
}