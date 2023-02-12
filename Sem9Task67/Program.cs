// Задача 67
// Напишите программу, которая принимает на вход число и 
// возвращает сумму чисел.


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// метод печати результата
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}
// метод рекурсии суммы цифр в числе
int RecSumDig(int n)
{
    if (n <= 10) return n;
    return n % 10 + RecSumDig(n / 10);
}
// цикл 
int SumDig(int n)
{
    int res = 0;
    while (n > 0)
    {
        res = res + n % 10;
        n = n / 10;
    }
    return res;

}

int numberN = ReadData("Введите число N: ");
int sum1 = RecSumDig(numberN);
PrintResult(sum1);

Console.WriteLine();
int sum2 = SumDig(numberN);
PrintResult(sum2);