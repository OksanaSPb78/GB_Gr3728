
// Задача №51
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
// диагонали (с индексами (0,0); (1;1) и т.д.


//1) Получение размерности матрицы
int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
//2) заполнили матрицу
int[,] matrix = Gen2DArr(xlen, ylen);
//3) Печатаем (смотрим что получилось) двумерный массив (матрицу)
Print2DArr(matrix);
// получить результат элементов по диагонали 
int sumOfDiagonal = DiagSum(matrix);
// выведем на печать диагональ 
Console.WriteLine(sumOfDiagonal);


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
            arr[i, j] = j+i;
        }
    }
    return arr;
}
// метод печати двумерного массива
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
// метод нахождения суммы элементав на главной диагонали
int DiagSum(int[,] arr)
{
    int res =0;
    int min=arr.GetLength(0)>arr.GetLength(1)?arr.GetLength(1):arr.GetLength(0);

   for (int i = 0; i < min; i=i+1)
    {
        // накапливаем элементы в главной диагонали
        res = res+ arr[i, i];
    } 
    return res;
}

