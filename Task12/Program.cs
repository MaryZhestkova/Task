// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int result;
    result = int.Parse(numb);
    return result;
} 

int SumOfDigits (int number)
{
    int result = 0; 
    while (number > 0)
    {
        result += number %10;
        number = number / 10;
    }
    return result; 
}
int number = ReadInt("Введите число");
System.Console.WriteLine($"Сумма всех цифр числа {number} равна {SumOfDigits(number)}");
