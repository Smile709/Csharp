﻿/* Известно значение температуры по шкале Цельсия. Найти соответствующее  значение температуры по шкале: 
а) Фаренгейта; 
б) Кельвина.
Для пересчета по шкале Фаренгейта необходимо исходное значение температуры умножить на 1,8 и к результату прибавить 32, 
а по шкале Кельвина абсолютное значение нуля соответствует -273,15 градуса по шкале Цельсия.
*/

Console.WriteLine("Введите температуру по C");
double tempC = Convert.ToDouble(Console.ReadLine());
double tempF = tempC * 1.8 + 32;
Console.WriteLine($"Температура по Фаренгейту: {Math.Round(tempF)}");
double tempK = tempC + 273.15;
Console.WriteLine($"Температура по Кельвину: {tempK:N2}");

