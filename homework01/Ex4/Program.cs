//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
string NumberStr = Console.ReadLine();
int Number = Convert.ToInt32(NumberStr);
if (Number%2 == 0) 
    { for (int i = 2;i <= Number; i=i+2)
        { Console.Write($"{i} ");}
    }
else 
    { for (int i = 2;i <= Number - 1; i=i+2)
    { Console.Write($"{i} ");}
    }

