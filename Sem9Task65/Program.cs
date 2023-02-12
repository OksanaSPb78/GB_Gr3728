// Задача 65
// Задать значения n и  m. Написать программу, которая найдет 
// все натуральные элементы в промежутке от m до  n.

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
string RecLineMN(int m, int n)
{
    if (m >= n)
    {
        return n.ToString();
    }
    else
    {

        return m + " " + RecLineMN(m + 1, n);
    }

}

// m=5 n=10
// 1 ВЫЗОВ
// string RecLineMN(5, 10)
// {
//     if (5 >= 10)
//     {
//         return 10.ToString();
//     }
//     else
//     {

//         return 5 + " " + 6 + " " + 7 + " " + 8 + " " + 9 + " " + 10;
//     }

// }
// 2 ВЫЗОВ
// string RecLineMN(6, 10)
// {
//     if (6 >= 10)
//     {
//         return 10.ToString();
//     }
//     else
//     {

//         return 6 + " " + 7 + " " + 8 + " " + 9 + " " + 10;
//     }

// }
// 3 ВЫЗОВ 
// string RecLineMN(7, 10)
// {
//     if (7 >= 10)
//     {
//         return 10.ToString();
//     }
//     else
//     {

//         return 7 + " " + 8 + " " + 9 + " " + 10;
//     }

// }
// 4 ВЫЗОВ
// string RecLineMN(8, 10)
// {
//     if (8 >= 10)
//     {
//         return 10.ToString();
//     }
//     else
//     {

//         return 8 + " " + 9 + " " + 10;
//     }

// }
// 5 ВЫЗОВ
// string RecLineMN(9, 10)
// {
//     if (9 >= 10)
//     {
//         return 10.ToString();
//     }
//     else
//     {

//         return 9 + " " + 10;
//     }

// }
// 6 ВЫЗОВ
// string RecLineMN(10, 10)
// {
//     if (10 >= 10)
//     {
// возвращает 10
// return 10.ToString(); 
//     }
//     else
//     {

//         return m + " " + RecLineMN(m + 1, n);
//     }

// }
// задаем число
int numberM = ReadData("Введите число m: ");
int numberN = ReadData("Введите число n: ");
// string res = RecLineMN(numberM, numberN);

// вызов рекурентного метода с тернарным оператором (защита от дурака)
string res = numberM<numberN? RecLineMN(numberM, numberN):RecLineMN(numberN, numberM);
PrintResult(res);