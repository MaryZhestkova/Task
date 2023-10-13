// SЗадача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);
    return number;
}
int number1 = ReadInt("Введите трехзначное число");
int result;
if (number1 > 99 && number1 < 1000)
{
    result = number1 / 10 % 10;
    Console.WriteLine(result);
}
else Console.WriteLine("введенное число не трехзначное");