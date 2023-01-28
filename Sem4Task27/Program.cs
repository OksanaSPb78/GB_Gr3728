// Задача 27 
// Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
//* Сделать оценку времени алгоритма через вещественные числа и строки

// Вариант 1 простой метод 

// Метод читает данные от пользователя
int ReadData(string msg)
{
    // Просим ввести 
    Console.WriteLine(msg);
    // Вводим переменную с проверкой на null
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод PrintData // вывод результата пользователю
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}
// Простой метод вычисления суммы чисел 
int SumSym(int num)
{
    int res = 0;
    while (num>0)
    {
        res=res+num%10;
        //уменьшим на один символ
        num=num/10;
    }
    return res;
}
// получим число от пользователя
int number = ReadData("Введите число: ");
// обратимся к методу, передавшему число 
int res1 = SumSym(number);
// Выводим на печать
PrintData("Сумма  чисел: ",res1);