// Написать игру - компьютер загадывает рандомное число, от 1 до 99 включительно. 
// Пользователь вводит число наугад, компьютер в зависимости от результата пишет больше или меньше 
// введенное пользователем число, чем число загаданное компьютером. Когда пользователь угадывает число, 
// компьютер поздравляет его с победой, выводит число на экран, и программа завершается

// // Подсказка: рекомендую while

int number = new Random().Next(1, 100); // число от 10 до 99 и переместили в переменную number

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);
    return number;
}
int anyNumber = ReadInt("Введите число от 1 до 99");
if (anyNumber == number)
{
    Console.WriteLine("Ура! С победой! Загаданное число " + number);
    break;
}
else if (anyNumber < 1 || anyNumber > 99)
{
    Console.WriteLine("Введенное число не соответствует критериям ввода");
    break;
}
else
{
    while (anyNumber > number)
    {
        Console.WriteLine("больше");
        int anyNumber = ReadInt("Ввведите число от 1 до 99");
    }
    while (anyNumber < number)
    {
        Console.WriteLine("меньше");
        int anyNumber = ReadInt("Ввведите число от 1 до 99");
    }
}