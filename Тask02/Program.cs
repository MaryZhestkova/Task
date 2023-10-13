// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 78->8 12-> 2 85->8
int number = new Random().Next(10, 100); // сгенерировали случайное число в диапозоне от 10 до 99 и переместили в переменную number
Console.WriteLine(number);
int FirstDigit = number / 10;
int LastDigit = number % 10; 
if(FirstDigit > LastDigit)
{
    Console.WriteLine(FirstDigit);
}
else 
{
    Console.WriteLine(LastDigit);
}