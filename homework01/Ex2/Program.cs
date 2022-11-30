Console.WriteLine("Задайте 3 числа");
Console.WriteLine("Введите первое число");
string FirstNumberStr = Console.ReadLine();
Console.WriteLine("Введите второе число");
string SecondNumberStr = Console.ReadLine();
Console.WriteLine("Введите третье число");
string ThirdNumberStr = Console.ReadLine();
int FirstNumber = Convert.ToInt32(FirstNumberStr);
int SecondNumber = Convert.ToInt32(SecondNumberStr);
int ThirdNumber = Convert.ToInt32(ThirdNumberStr);
int Maxima = FirstNumber;
if (SecondNumber > Maxima)
    {Maxima = SecondNumber;}
if (ThirdNumber > Maxima)
    {Maxima = ThirdNumber;}
Console.WriteLine($"max = {Maxima}");