// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления


int ReadInt(string msg) // объявляем функцию ReadInt и строковый параметр msg
{
    Console.WriteLine(msg); // пишет в терминал параметр msg
    string numb = Console.ReadLine(); // функция считывания строки с консоли (терминала)
    int number; // объявление переменной number
    number = int.Parse(numb); // результат преобразования строки в число
    return number; // возврат из функции
} // описание функции заканчивается
int number1 = ReadInt("Введите первое число");
int number2 = ReadInt("Введите второе число");
int result = number1%number2;
if (result == 0)
{
    Console.WriteLine("кратно");
}
else Console.WriteLine("некратно, остаток равен " + result);