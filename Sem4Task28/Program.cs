
//Задача №28 факториал 
//Напишите программу, которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N.

// Вариант 1 
using System.Numerics;
// Метод читает данные от пользователя
int ReadData(string msg)
{
    // Просим ввести координаты х
    Console.WriteLine(msg);
    // Вводим переменную с проверкой на null
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод PrintData // вывод результата пользователю
void PrintData(string msg1, BigInteger msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}
// Метод вычисления факториала CalcFact
BigInteger CalcFact(int num)
{
    //Создаем переменную
    BigInteger res = 1;
    for (int i = 1; i <= num; i++)
    {
        res = res * i;
    }
    return res;
}
int number = ReadData("Введите число: ");
BigInteger fact = CalcFact(number);
PrintData("Факториал равен^ ", fact);
