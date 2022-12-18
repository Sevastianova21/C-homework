// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
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
double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double temp = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return temp;
}
int x1 = GetNumber ("Введите координату x1");
int y1 = GetNumber ("Введите координату y1");
int z1 = GetNumber ("Введите координату z1");
int x2 = GetNumber ("Введите координату x2");
int y2 = GetNumber ("Введите координату y2");
int z2 = GetNumber ("Введите координату z2");
Console.WriteLine($"Расстояние = {Distance(x1, x2, y1, y2, z1, z2)}");