//    Задача 8: 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Вариант 1
// Просим пользователя ввести число
Console.WriteLine("Input your number");

//Считываем данные с консоли 
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{
    //Парсим введённое число (преобразуем введенные строки в числа) 
    int inputNumberN = int.Parse(inputLine);

    // Cоздаем выходную переменную
    string outNumLine = string.Empty;
    
    // Запускаем цикл for
    for (int i = 2; i < inputNumberN; i = i+2)
       {
    // Аккумулируем числа до числа N
        outNumLine = outNumLine + i + ",";
       }
// Отбираем четные числа до N
        if (inputNumberN%2 == 0)
            outNumLine = outNumLine + inputNumberN;
         
    // Выводим результат

    Console.WriteLine(outNumLine);
    
}