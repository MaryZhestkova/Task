// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
int ReadInt(string msg) // объявляем функцию ReadInt и строковый параметр msg
{
    Console.WriteLine(msg); // пишет в терминал параметр msg
    string numb = Console.ReadLine(); // функция считывания строки с консоли (терминала)
    int number; // объявление переменной number
    number = int.Parse(numb); // результат преобразования строки в число
    return number; // возврат из функции
} // описание функции заканчивается
int number1 = ReadInt("Введите число");
int result1 = number1%7;
int result2 = number1%23;

if (result1 == 0 & result2 == 0)
{
    Console.WriteLine("кратно");
}
else Console.WriteLine("некратно");