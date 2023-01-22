//    Задача 23
//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64,
// Ввод данных
Console.Write("Введите N: ");
int num = int.Parse(Console.ReadLine() ?? "0");
// получим число N
string LineBuilder(int n, int p)
{
    string res = "";
    for (int i = 1; i < n; i++)
    {
        res += Math.Pow(i, p).ToString() + " \t ";
    }
    return res;
}
// Вывод данных
Console.WriteLine(LineBuilder(num, 1));

Console.WriteLine(LineBuilder(num, 3));

// ВАРИАНТ 2
