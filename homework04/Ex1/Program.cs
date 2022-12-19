// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
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
int GetDegree(int firstNumber, int secondNumber)
{
    int degree = 1;
    for (int i = 0; i < secondNumber; i++)
    {
        degree = degree * firstNumber;
    }
    return degree;
}
int firstNumber = GetNumber("Введите число A");
int secondNumber = GetNumber("Введите число B");
Console.WriteLine($"А в степени В = {GetDegree(firstNumber,secondNumber)}");
