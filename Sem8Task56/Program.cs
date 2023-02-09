// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m, n);
Print2DArray(matrix);
NumMinSumRow2DArray(matrix);
Console.WriteLine();
Print2DArray(matrix);

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// метод генерации двумерного массива 
int[,] Gen2DArray(int xlen, int ylen)
{
    int[,] arr = new int[ylen, xlen];
    for (int i = 0; i < ylen; i++)
    {
        for (int j = 0; j < xlen; j++)
        {
            arr[i, j] = j + i;
        }
    }
    return arr;
}
// Печать двумерного массива
void Print2DArray(int[,] matr)

{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// метод поиска строки с наименьшей суммой элементов (не индексов)
void NumMinSumRow2DArray(int[,] arr)
{
    int minRow = 0;
    int numMinSum = 0;
    int bufRow = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        minRow += arr[0, 1];
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) bufRow += arr[i, j]; ;
              
        if (bufRow < minRow)
        {
            minRow = bufRow;
            numMinSum = i;
        }

        bufRow = 0;
    }
    Console.Write($"{numMinSum + 1} -номер строки с наименьшей суммой элементов");
}
