// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int power(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
        result = result * A;
    return result;
}

Console.WriteLine("Введите первое число");
int chislo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int stepen = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(power(chislo, stepen));
