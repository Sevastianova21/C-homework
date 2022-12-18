// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
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
int number = GetNumber ("Введите число");
for(int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i}^3 = {Math.Pow(i,3)}");
}