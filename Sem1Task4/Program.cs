//    Задача 4: 
//  Напишите программу, которая принимает на вход три числа 
//  и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

//    Вариант 1
// Просим пользователя ввести три  числа
Console.WriteLine("Введите три числа");

//Считываем данные с консоли 
string? inputLine1 = Console.ReadLine();
string? inputLine2 = Console.ReadLine();
string? inputLine3 = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inputLine1 != null && inputLine2 != null && inputLine3 != null)
{
    //Парсим введённые  числа(преобразуем введенные строки в числа) 
    int inputNumber1 = int.Parse(inputLine1);
    int inputNumber2 = int.Parse(inputLine2);
    int inputNumber3 = int.Parse(inputLine3);

    // Выводим какое из трёх чисел больше
    if (inputNumber1 > inputNumber2)
    {
        if (inputNumber1 > inputNumber3)
        {
            Console.WriteLine(inputNumber1);
        }
        else
        {
            Console.WriteLine(inputNumber3);
        }
    }
    else
             if (inputNumber2 > inputNumber3)
    {
        Console.WriteLine(inputNumber2);

    }
    else
        Console.WriteLine(inputNumber3);


}

