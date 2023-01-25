//Задача №26
//Напишите программу, которая принимает на вход число и выдаёт количество 
//цифр в числе.
//Пример:
//456 -> 3
//78 -> 2
//89126 -> 5

// Вариант 1 
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
// Метод аналитическийподсчета количество символов в заданном 
// числе SumDigit
// Объявим метод
int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        // копим результат
        res++;
        // отбрасываем по одному числу
        num = num / 10;
    }
    // возвращаем значение
    return res;
}
// Метод через превращение в строку (Савелий)
int SumDigitStr(int num)
{
    int res = 0;
    res = num.ToString().Length;
    return res;
}
int VariantLog(int num)
{
    int count = (int)Math.Log10(num) + 1;
    return count;
}
int number = ReadData("Введите число: ");
// Подсчет времени исполнения метода
DateTime d1 = DateTime.Now;
int res1 = SumDigit(number);
Console.WriteLine(DateTime.Now - d1);
// Вывод результата
PrintData("Вариант (SumDigit): ", res1);

// Подсчет времени исполнения метода
DateTime d2 = DateTime.Now;
int res2 = SumDigitStr(number);
Console.WriteLine(DateTime.Now - d2);
// Вывод результата
PrintData("Вариант (SumDigitStr): ", res2);

// Подсчет времени исполнения метода
DateTime d3 = DateTime.Now;
int res3 = VariantLog(number);
Console.WriteLine(DateTime.Now - d3);
// Вывод результата
PrintData("Вариант (VariantLog): ", res3);
