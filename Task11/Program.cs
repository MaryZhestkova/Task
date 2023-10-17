// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double ReadInt(string msg) // объявляем функцию ReadInt и строковый параметр msg
{
    Console.WriteLine(msg); // пишет в терминал параметр msg
    double number = Convert.ToInt16(Console.ReadLine());
    return number; // возврат из функции
} // описание функции заканчивается
double result;
double chislo = ReadInt("Введите первое число");
double stepen = ReadInt("Введите второе число");
result = Math.Pow(chislo, stepen);
System.Console.WriteLine(result);
