// Задача №0
// Напишите программу, которая на вход принимает
// число и выдает его квадрат (число, 
// умноженное на само себя).

// Считываем данные с консоли
string? inputNum = Console.ReadLine();

// // Проверяем, чтобы данные были не пустыми
if (inputNum != null)
{
    //  Парcим введенное число
    int number = int.Parse(inputNum);
    //   Находим квадрат числа
    //     // int result = number * number;
    //     int result = (int)Math.Pow(number,2);
    //  Выводим данные в консоль
    //     Console.WriteLine(result);

    int result = number * number;
    Console.WriteLine(Math.Pow(int.Parse(inputNum), 2));

    //Оценка скорости
    DateTime d1 = DateTime.Now;
    for (int i = 0; i < 1000000; i++)
    {
        result = number * number;
    }

    DateTime d2 = DateTime.Now;
    Console.WriteLine(DateTime.Now - d2);
}
