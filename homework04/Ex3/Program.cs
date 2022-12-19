// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}
int[] array = InitArray(8);
PrintArray(array);