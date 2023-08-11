/* Составить программу обмена значениями двух переменных величин.
*/

System.Console.WriteLine("Введите две переменных");
int var1 = Convert.ToInt32(Console.ReadLine());
int var2 = Convert.ToInt32(Console.ReadLine());
int temp=var1;
var1=var2;
var2=temp;
Console.WriteLine($"Первая переменная теперь {var1},{Environment.NewLine} а вторая переменная {var2}");

