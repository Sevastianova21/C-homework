// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
string NumberStr = Console.ReadLine();
int Number = Convert.ToInt32(NumberStr); // избавляемся от нулей спереди, если кто то решил ввести  
string QNumberStr = Convert.ToString(Number);
if (Number < 100){ 
    Console.WriteLine("Третей цифры нет");}
else {
    Console.WriteLine($"Третья цифра {QNumberStr[2]}");}