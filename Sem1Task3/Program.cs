// Задача №3
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

//  Считываем данные с консоли
string? inputLine = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{
    // ВАРИАНТ 1
    //     // Создаем массив с количеством дней недели
    //     string[]dayWeek = new string[7];
    //     dayWeek[0] = "Monday";
    //     dayWeek[1] = "Tuesday";
    //     dayWeek[2] = "Wednesday";
    //     dayWeek[3] = "Thursday";
    //     dayWeek[4] = "Friday";
    //     dayWeek[5] = "Saturday";
    //     dayWeek[6] = "Sunday";
    //     // Парсим введенное число
    //     int inputNum = int.Parse(inputLine);
    //     // Находим название дня недели по введенному номеру
    //     string dayofWeek = dayWeek[inputNum -1];
    //     // Выводим данные в консоль
    //     Console.WriteLine(dayofWeek);

    // }
    // ВАРИАНТ 2
    int inputNumber = int.Parse(inputLine);
    // string outDayOfWeek = string.Empty;
    //  switch (inputNumber)
    // {
    //     case 1: outDayOfWeek = "понедельник"; break;
    //     case 2: outDayOfWeek = "вторник"; break;
    //     case 3: outDayOfWeek = "среда"; break;
    //     case 4: outDayOfWeek = "четверг"; break;
    //     case 5: outDayOfWeek = "пятница"; break;
    //     case 6: outDayOfWeek = "суббота"; break;
    //     case 7: outDayOfWeek = "воскресенье"; break;
    //     default: outDayOfWeek = "это не день недели!"; break;
    // }
    // Console.WriteLine(outDayOfWeek);
    // ВАРИАНТ 3
    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));
    Console.WriteLine(outDayOfWeek);
}