// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);
    return number;
}
int dayNumber = ReadInt("Введите число от 1 до 7");
if (dayNumber > 0 && dayNumber < 6)
{
    Console.WriteLine("будний день");
}
else if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("выходной день");
}
else Console.WriteLine("введенное число не день недели");