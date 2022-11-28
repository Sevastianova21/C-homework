
Console.WriteLine("Задайте 2 числа");
Console.WriteLine("Введите первое число");
string FirstNumberStr = Console.ReadLine();
Console.WriteLine("Введите второе число");
string SecondNumberStr = Console.ReadLine();
int FirstNumber = Convert.ToInt32(FirstNumberStr);
int SecondNumber = Convert.ToInt32(SecondNumberStr);
if (FirstNumber > SecondNumber)
    {Console.WriteLine($"max = {FirstNumber}");}
else 
    {Console.WriteLine($"max = {SecondNumber}");}
