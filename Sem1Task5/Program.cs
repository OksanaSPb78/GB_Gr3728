//    Задача №5
// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.

//Считываем данные с консоли 
// string? imputNumLine = Console.ReadLine();
// // Проверяем, чтобы данные не были пустыми
// if (imputNumLine != null)
// {
//     // Парсим введенное число
//     int imputNumberA = int.Parse(imputNumLine);
//     // Вводим промежуточное значение
//     int imputNumberC = imputNumberA * (-1);
//     // Зоздаем выходную переменную
//     string outNumLine = string.Empty;
//     // Запускаем цикл (пока)
//     while (imputNumberC < imputNumberA)
//     {
//         outNumLine = outNumLine + imputNumberC + ",";
//         imputNumberC = imputNumberC + 1;
//     }
//     // Добавляем значение, который будет не достигнут
//     outNumLine = outNumLine + imputNumberA;
//     // Вывод значения пользователю
//     Console.WriteLine(outNumLine);
// }

// Вариант Савелия 
// Приглашение ввести число
Console.Write("input your num: ");
// Вводим число (считываем данные с консоли)
string? inputNum = Console.ReadLine();
// Проверяем это число, чтобы оно не было нулевым (данные не пустые)
if (inputNum != null)
{
    // Преобразуем (парсим) это число в значение
    int num = int.Parse(inputNum);
    // Цикл for (выполняет указанный код множество раз)
    for (int i = 0; i < num * 2; i++)
    {
        // Вывод каждого числа отдельно
        Console.Write(i - num);
        // Дописываем "," к каждой строке
        Console.Write(", ");
    }
    Console.Write(num);
}