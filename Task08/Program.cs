// Написать игру - компьютер загадывает рандомное число, от 1 до 99 включительно. 
// Пользователь вводит число наугад, компьютер в зависимости от результата пишет больше или меньше 
// введенное пользователем число, чем число загаданное компьютером. Когда пользователь угадывает число, 
// компьютер поздравляет его с победой, выводит число на экран, и программа завершается


// // + уровни сложности

System.Console.WriteLine("Угадай число от 1 до 99");

int number = new Random().Next(1, 100); // число от 10 до 99 и переместили в переменную number
int anyNumber;
Console.WriteLine("Выберите уровень сложности: 1 - легкий (10 попыток), 2 - средний (7 попыток), 3 - сложный (4 попытки)");
int level = Convert.ToInt32(Console.ReadLine());
if (level == 0 || level > 3)
    Console.WriteLine("Неверный ввод уровня");
if (level == 1)
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write("Введите число: ");
        anyNumber = Convert.ToInt32(Console.ReadLine());

        if (anyNumber > number)
        {
            Console.WriteLine("Введенное число больше загаданного");
        }
        else if (anyNumber < number)
        {
            Console.WriteLine("Введенное число меньше загаданного");
        }
        if (anyNumber == number)
            System.Console.WriteLine("Ура! Победа! Загаданное число " + number);

    }
    Console.WriteLine("Вы истратили 10 попыток. Проигрыш");
}
if (level == 2) {
    for (int i = 0; i < 7; i++)
    {
        Console.Write("Введите число: ");
        anyNumber = Convert.ToInt32(Console.ReadLine());

        if (anyNumber > number)
        {
            Console.WriteLine("Введенное число больше загаданного");
        }
        else if (anyNumber < number)
        {
            Console.WriteLine("Введенное число меньше загаданного");
        }
        if (anyNumber == number)
            System.Console.WriteLine("Ура! Победа! Загаданное число " + number);
        
    }
    Console.WriteLine("Вы истратили 7 попыток. Проигрыш");
}
if (level == 3) {
    for (int i = 0; i < 4; i++)
    {
        Console.Write("Введите число: ");
        anyNumber = Convert.ToInt32(Console.ReadLine());

        if (anyNumber > number)
        {
            Console.WriteLine("Введенное число больше загаданного");
        }
        else if (anyNumber < number)
        {
            Console.WriteLine("Введенное число меньше загаданного");
        }
        if (anyNumber == number)
            System.Console.WriteLine("Ура! Победа! Загаданное число " + number);
        
    }
    Console.WriteLine("Вы истратили 4 попытки. Проигрыш");
}