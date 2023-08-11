/* Cоставить программу обмена значениями трех переменных величин а, b, c по
следующим двум схемам: 
    а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
    б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
    */
System.Console.WriteLine("Введите две переменных");
int varA = Convert.ToInt32(Console.ReadLine());
int varB = Convert.ToInt32(Console.ReadLine());
int varC = Convert.ToInt32(Console.ReadLine());
int tempA = varA;
int tempB = varB;
varB = varC;
varA = tempB;
varC = tempA;
Console.WriteLine($"Первая переменная A= {varA},{Environment.NewLine}Вторая переменная B= {varB},{Environment.NewLine}а третья переменная C= {varC}");
