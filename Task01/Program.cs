int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);
    return number;
}
int number=ReadInt("Введите трехзначное число ");
if (number > 99 & number <1000)
{
    int LastDigit = number % 10;
    Console.WriteLine("Третье число = " + LastDigit);
}
else Console.WriteLine("Число не трехзначное");