// Возведение числа в степень

int power(int a, int b){
    int result = 1;
    for (int i = 1; i<=b; i++)
    result = result * a;
    return result;
}
Console.WriteLine("Ввведите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввведите cтепень: ");
int stepen = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(power(chislo, stepen));