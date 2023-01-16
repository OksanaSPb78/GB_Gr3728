//    Задача 2: 
// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

//    Вариант 1
// // Просим пользователя ввести два числа
// Console.WriteLine("Введите два числа");

// //Считываем данные с консоли первое число
// string? inputLine1 = Console.ReadLine();
// //Считываем данные с консоли второе число
// string? inputLine2 = Console.ReadLine();
// //Проверяем, чтобы данные были не пустыми
// if (inputLine1 != null && inputLine2 != null)
// {
//     //Парсим введенное первое число
//     int inputNumberA = int.Parse(inputLine1);
//     //Парсим введенное второе число
//     int inputNumberB = int.Parse(inputLine2);

//     // Создаем условие: какое из введенных чисел большее
//     if (inputNumberA > inputNumberB)

//         Console.WriteLine("Первое число > второго числа");

//     else

//         Console.WriteLine("Второе число > первого числа");


//     Console.WriteLine();

// }
// Вариант 2
// // Просим пользователя ввести два числа
// Console.WriteLine("Введите два числа");

// //Считываем данные с консоли первое число
// string? inputLine1 = Console.ReadLine();
// //Считываем данные с консоли второе число
// string? inputLine2 = Console.ReadLine();
// //Проверяем, чтобы данные были не пустыми
// if (inputLine1 != null && inputLine2 != null)
// {
//  //Парсим введенное первое число
// int inputNumberA = int.Parse(inputLine1);
// //Парсим введенное второе число
//  int inputNumberB = int.Parse(inputLine2);
//  // Создаем условие: какое из введенных чисел большее
//   if (inputNumberA > inputNumberB)
// // Вывод числа с текстом и значением
//      Console.Write($"Первое число больше второго: {inputNumberA}");

//    else
// // Вывод числа с текстом и значением

//    Console.Write($"Второе число больше первого числа: {inputNumberB}");

// }

//    Вариант 3 

// Просим пользователя ввести два числа
Console.WriteLine("Введите два числа");

//Считываем данные с консоли 
string? inputLine1 = Console.ReadLine();
string? inputLine2 = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (inputLine1 != null && inputLine2 != null)
{
    //Парсим введенные числа
    int inputNumberA = int.Parse(inputLine1);
    int inputNumberB = int.Parse(inputLine2);
    // Создаем условие: какое из введенных чисел большее
    if (inputNumberA > inputNumberB)
    {
        // Вывод максимального числа без текста
        Console.Write($"max=: {inputNumberA}");
    }
    else
    {
        // Вывод максимального сила без текста
        Console.Write($"max=: {inputNumberB}");
    }
}