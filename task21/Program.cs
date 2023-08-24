/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Введите X, Y и Z Первой точки: ");
int userX1 = Convert.ToInt32(Console.ReadLine());
int userY1 = Convert.ToInt32(Console.ReadLine());
int userZ1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X, Y и Z Второй точки: ");
int userX2 = Convert.ToInt32(Console.ReadLine());
int userY2 = Convert.ToInt32(Console.ReadLine());
int userZ2 = Convert.ToInt32(Console.ReadLine());

double rastXYZ = Math.Sqrt((userX2-userX1)*(userX2-userX1)+(userY2-userY1)*(userY2-userY1)+(userZ2-userZ1)*(userZ2-userZ1));
double roundedNumber = Math.Round(rastXYZ,2);
Console.WriteLine (roundedNumber);
