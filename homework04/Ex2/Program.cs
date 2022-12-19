// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Ввели не корректное число.");
    }

    return result;
}
int GetSumm(int number)
{
    int temp = number;
    int summ = 0;
    int digit = 0;

    while (temp > 0)
    {
        digit = temp % 10;
        summ = summ + digit;
        temp = temp / 10;
    }
    return summ;
}
int number = GetNumber("Введите число");
Console.WriteLine($"сумма цифр в числе = {GetSumm(number)}");
