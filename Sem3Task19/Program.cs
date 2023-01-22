//   Задача 19
//Напишите программу, которая принимает на вход пятизначное число и
//проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

//   ВАРИАНТ 1
// Приглашение пользователю ввести число
Console.WriteLine("Введите пятизначное число:");
// Вводим переменную num с проверкой на null
int num = int.Parse(Console.ReadLine() ?? "0");
//  метод вычисления палиндрома
PalinTest(num);
// Выводим результат пользователю
void PalinTest(int num)
{
    if (num >= 10000)
    {
        int division1 = num / 10000;
        int remainder1 = num % 10;

        if (division1 == remainder1)
        {
            num = num / 10;
            int division2 = (num / 100) % 10;
            int remainder2 = num % 10;
            if (division2 == remainder2)
                Console.WriteLine("Да");
        }
        else
            Console.WriteLine("Нет");

    }
    else
        Console.WriteLine("Некорректное число!");
}

