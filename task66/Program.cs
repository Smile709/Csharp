/* 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
System.Console.WriteLine("Введи М: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNuturalNum(int min, int max)
{   if (min == max) return min;
    else
    {
       return min+SumNuturalNum(min+1,max);
    }    
}   ;
System.Console.WriteLine($"Сумма чисел в промежутке от {m} до {n} равна: {SumNuturalNum(m,n)}");