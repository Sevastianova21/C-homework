// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
string NumberStr = Console.ReadLine();
int Number = Convert.ToInt32(NumberStr);
int Digit = Number/10%10;
Console.WriteLine($"Вторая цифра {Digit}");