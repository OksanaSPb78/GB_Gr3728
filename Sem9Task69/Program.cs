// Задача 69
// Напишите программу, которая будет принимать два числа а и b
// и возводить число а в степень и с помощью рекурсии.

// метод ввода данных с консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// метод печати результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}
//  метод возведения числа а в степень b
long RecPowFlow(int a, int b)
{
    if (b <= 1) return a;
    return a * RecPowFlow(a, b - 1);
}
// метод рекурентный возведения числа а в степень b
long MyPow(int a, int b)
{
    if (b == 2) return a * a;
    return MyPow(a, b / 2) * MyPow(a, b / 2);
}
//  ввод данных
int numberA = ReadData("Введите число A: ");
int numberB = ReadData("Введите число B: ");
// создаем переменные
long res1 = 0;
long res2 = 0;
// измеряем скорость методов
DateTime d1 = DateTime.Now;
res1 = RecPowFlow(numberA, numberB);
PrintResult("Решение RecPowFlow " + (DateTime.Now - d1));

DateTime d2 = DateTime.Now;
res2 = RecPowFlow(numberA, numberB);
PrintResult("Решение MyPow " + (DateTime.Now - d2));