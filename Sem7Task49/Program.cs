// Задача №49
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

//1) Получение данных от пользователя
int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
//2) Генерация двумерного массива
int[,] matrix = Gen2DArr(xlen, ylen);
//3) Печатаем (смотрим что получилось) двумерный массив
Print2DArr(matrix);
// после просмотра обновляем массив
Update2DArr(matrix);
// пустая строка
Console.WriteLine();
// смотрим после обновления массив
Print2DArr(matrix);

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
// метод нахождения четных индексов двумерного массива и возведение их в квадрат
void Update2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < arr.GetLength(1); j = j + 2)
        {
            // варианты возведения в квадрат
            // arr[i, j]*=arr[i, j] ;  
            //arr[i, j]=arr[i, j]*arr[i, j];
            arr[i, j] = (int)Math.Pow(arr[i, j], 2);
        }
    }
}


