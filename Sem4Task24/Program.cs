
//Задача №24
//Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.
//Например:
//7 -> 28
//4 -> 10
//8 -> 36

// // Вариант 1 простой метод 

// // Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     // Просим ввести 
//     Console.WriteLine(msg);
//     // Вводим переменную с проверкой на null
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// //Метод PrintData // вывод результата пользователю
// void PrintData(string msg1, int msg2)
// {
//     Console.WriteLine(msg1);
//     Console.WriteLine(msg2);
// }
// // Простой метод вычисления суммы чисел от 1 до А
// int SumSimple(int numA)
// {
//     int sumOfNum = 1;
//     for (int i = 2; i <= numA; i++)
//     {
//         sumOfNum += i;
//     }
//     return sumOfNum;
// }
// // получим число от пользователя
// int numberA = ReadData("Введите число А");
// // обратимся к методу, передавшему А
// int res1 = SumSimple(numberA);
// // Выводим на печать
// PrintData("Сумма чисел от 1 до A(SumSimple): ",res1);

// // Вариант 2 (формула Гаусса)

// //Метод ReadData //ввод данных
// // Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     // Просим ввести данные
//     Console.WriteLine(msg);
//     // Вводим переменную с проверкой на null
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// //Метод PrintData // вывод результата пользователю
// void PrintData(string msg1, int msg2)
// {
//     Console.WriteLine(msg1);
//     Console.WriteLine(msg2);
// }
// // простой метод вычисления суммы чисел от 1 до А
// int SumSimple(int numA)
// {
//     int sumOfNum = 1;
//     for (int i = 2; i <= numA; i++)
//     {
//         sumOfNum += i;
//     }
//     return sumOfNum;
// }
// int SumGauss(int numA)
// {
//     return (numA * (numA + 1)) / 2;
// }
// int numberA = ReadData("Введите число А");

// int res1 = SumSimple(numberA);
// int res2 = SumGauss(numberA);

// PrintData("Сумма чисел от 1 до A(SumSimple): ",res1);
// PrintData("Сумма чисел от 1 до A(SumGauss): ",res2);

//Вариант 3 (установим время выполнения метода)

//Метод ReadData //ввод данных
// Метод читает данные от пользователя
int ReadData(string msg)
{
    // Просим ввести координаты х
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
// простой метод вычисления суммы чисел от 1 до А
int SumSimple(int numA)
{
    int sumOfNum = 1;
    for (int i = 2; i <= numA; i++)
    {
        sumOfNum += i;
    }
    return sumOfNum;
}
int SumGauss(int numA)
{
    return (numA * (numA + 1)) / 2;
}
int numberA = ReadData("Введите число А");
DateTime d1 = DateTime.Now;
int res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = SumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintData("Сумма чисел от 1 до A(SumSimple): ", res1);
PrintData("Сумма чисел от 1 до A(SumGauss): ", res2);