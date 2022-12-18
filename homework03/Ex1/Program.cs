// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result / 10 != 5)
            isCorrect = true;
        else
            Console.WriteLine("Ввели не корректное число.");
    }

    return result;
}
string Check(int number)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
        return "палиндром";
    else
        return "не палиндром";

}
int number = GetNumber("Введите пятизначное число");
Console.WriteLine($"{Check(number)}");

