// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
//  элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ 
// выделить разным цветом.


//1) Получение данных от пользователя
int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] matrix = Gen2DArr(xlen, ylen);
//3) Печатаем (смотрим что получилось) двумерный массив
Print2DArr(matrix);
int[]meanColum=MeanColum(matrix);
Print1DArray(meanColum);


// метод ввода данных от пользователя
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// метод генерации двумерного массива 
int[,] Gen2DArr(int xlen, int ylen)

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
//метод для печати двумерного массива
void Print2DArr(int[,] arr)

{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}
// метод вычисления среднего арифметического столбца в двумерном массиве
int[] MeanColum(int[,] arr)
{
    // ввод одномерного массива
    int[] means = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            means[i] =+ arr[i, j];
        }
        means[i] = means[i] / arr.GetLength(1);
    }
    return means;
}
// печать одномерного массива
void Print1DArray(int[]arr)
{
    Console.Write("[");
    for (int i=0; i<arr.Length-1;i++)
    {
        Console.Write(arr[i]+ ",");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}