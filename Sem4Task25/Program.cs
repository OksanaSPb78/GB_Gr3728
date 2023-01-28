//    Задача 25 
// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//* Написать калькулятор с операциями +, -, /, * и возведение в степень
// ВАРИАНТ 1

//Метод читает данные от пользователя
int ReadData(string msg)
{
    // Просим ввести данные
    Console.WriteLine(msg);
    // Вводим переменную с проверкой на null
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

// метод возведения числа в степень
int degPow(int a, int b)
{
    int res = 1;
    res = Convert.ToInt32(Math.Pow(a, b));

    return res;
}

// Вводим данные от пользователя
int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число B: ");
// обратимся к методу, передавшему число 
 int res1 = degPow(numA, numB);
// Выводим на печать
PrintData("Число A в степени B равно: ", res1.ToString());

