//     Задача 6: 
// Напишите программу, которая на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два
// без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Вариант 1
// Просим пользователя ввести число
Console.WriteLine("Введите число");

//Считываем данные с консоли 
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{
    //Парсим введённое число (преобразуем введенные строки в числа) 
    int inputNumber = int.Parse(inputLine);
    // Проверим введенное число на чётность (посмотрим остаток от деления на 2)
    if(inputNumber%2== 0)
    
        Console.WriteLine("yes");
    
    else
    
        Console.WriteLine("no");
    

}