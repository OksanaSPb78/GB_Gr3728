﻿//    ЗАДАЧА 16
// Напишите программу, которая будет на вход принимать два  числа и проверять
// является ли одно квадратом другого
//
// //  ВАРИАНТ 1
// // Ввод первого числа
// int num1 = int.Parse(Console.ReadLine() ?? "0");
// // Ввод второго числа
// int num2 = int.Parse(Console.ReadLine() ?? "0");
// // Сравниваем первое число и второе
// if (num1 * num1 == num2)
// {
//     Console.WriteLine("Второе число является квадратом первого:");
// }
// // Сравниваем второе число и первое
// ifelse(num2 * num2 == num1);

// Console.WriteLine("Первое число является квадратом второго:");

//        else
// {

//     Console.WriteLine("Не является квадратом:");

// }

// //   Вариант 2 Савелий
// Console.WriteLine("input yor nums: ");
// // Вводим данные с консоли
// int num1 = int.Parse(Console.ReadLine() ?? "0");// Ввод первого числа
// int num2 = int.Parse(Console.ReadLine() ?? "0");// Ввод второго числа
// //сравнение возведённого в квадрат числа с другим числом
// if ((int)Math.Pow(num1, 2) == num2)
// {
//     // Вывод согласия
//     Console.Write("да, число " + num1 + " является степенью  числа " + num2);
// }
// if ((int)Math.Pow(num2, 2) == num1)
// {
//     // Вывод согласия
//     Console.Write("да, число " + num2 + " является степенью  числа " + num1);
// }
// else
// {
//     // Вывод согласия
//     Console.Write("нет, число " + num1 + " и  " + num2 + " не является чьей либо степенью");
// }

//    ВАРИАНТ 3
//   Вариант 2 Савелий
Console.WriteLine("input yor nums: ");
// Вводим данные с консоли
int num1 = int.Parse(Console.ReadLine() ?? "0");// Ввод первого числа
int num2 = int.Parse(Console.ReadLine() ?? "0");// Ввод второго числа
// Проверим квадратность первого числаи на второе и наоборот
TestSQRT(num1, num2);
TestSQRT(num2, num1);

// Создаем оболочку кода (метод) 
void TestSQRT(int i, int j)
{
    //сравнение возведённого в квадрат числа с другим числом
    if ((int)Math.Pow(i, 2) == j)
    {
        // Вывод согласия
        Console.WriteLine("да, число " + j + " является квадратом  числа " + i);
    }
    else
    {
        // Вывод согласия
        Console.WriteLine("число " + j + " не является квадратом  числа " + i);
    }
}