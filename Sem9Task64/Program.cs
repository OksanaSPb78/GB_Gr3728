// Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5. -> "5, 4, 3, 2, 1"
// N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"

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
        return num + "," + LineGenRec(num - 1);
        
        //  от 1 до n
        // return LineGenRec(num - 1) + " " + num;
    }

}
// задаем число
int number = ReadData("Введите число N=  ");
// вызов рекурентного метода
string resultLine = LineGenRec(number);
PrintResult(resultLine);