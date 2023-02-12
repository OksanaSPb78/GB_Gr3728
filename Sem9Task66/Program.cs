// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// метод чтения данных из консоли
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

// метод рекурсивный  суммы чисел в промежутке от M до N
int RecSumMN(int m, int n)
{

    if (m >= n)
    {
        return n;
    }
    else
    {

        return m + RecSumMN(m + 1, n);
    }
}
// задаем число
int numberM = ReadData("Введите число m: ");
int numberN = ReadData("Введите число n: ");
// string res = RecLineMN(numberM, numberN);

// вызов рекурентного метода с тернарным оператором (защита от дурака)
int res = numberM<numberN? RecSumMN(numberM, numberN):RecSumMN(numberN, numberM);
PrintResult(res);