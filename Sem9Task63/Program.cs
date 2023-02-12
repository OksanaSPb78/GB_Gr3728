// Задача  63:
// Напишите программу, которая выведет все натуральные числа в 
// промежутке от n до 1. Выполнить с помощью рекурсии.

// метод чтения данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// метод печати результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}
// метод генерации строки рекурентности
// 1 2 3 4 5 ... n
string LineGenRec(int num)
{
    if (num == 0)
    {
        return string.Empty;
    }
    else
    {
        // от n до 1
        // return num + " " + LineGenRec(num - 1);
        
        //  от 1 до n
        return LineGenRec(num - 1) + " " + num;
    }

}
// задаем число
int number = ReadData("Введите число n: ");
// вызов рекурентного метода
string resultLine = LineGenRec(number);
PrintResult(resultLine);
