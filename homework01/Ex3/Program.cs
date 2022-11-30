// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
string NumberStr = Console.ReadLine();
int Number = Convert.ToInt32(NumberStr);
if (Number%2 == 0) 
    { Console.WriteLine("Четное");}
else { Console.WriteLine("Нечетное");}