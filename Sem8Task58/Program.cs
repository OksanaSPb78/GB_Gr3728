// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// ВАРИАНТ 1
int rows = ReadData("Введите количество строк: ");
int columns = ReadData("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

Fill2DArrRandom(array);
Print2DArray(array);
Console.WriteLine();

Fill2DArrRandom(secondArray);
Print2DArray(secondArray);
Console.WriteLine();

MultiplOfTwoMatrix(array,secondArray,resultArray);
Print2DArray(resultArray);

// метод перемножения двух матриц
void MultiplOfTwoMatrix(int [,]array,int [,] secondArray,int[,]resultArray)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}
}

// метод ввода данных из консоли
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// метод  заполнения двумерного массива случайными числами от 1 до 9
void Fill2DArrRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// метод печати  двумерного массива 
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}










// // ВАРИАНТ 2

// int rows = ReadData("Введите количество строк : ");
// int colums = ReadData("Введите количество столбцов: ");
// int[,] matrix = Gen2DArray(rows, colums);
// Print2DArray(matrix);


// int rows2 = ReadData("Введите количество строк Второй матрицы: ");
// int colums2 = ReadData("Введите количество столбцов Второй матрицы: ");
// int[,] matrix2 = Gen2DArray2(rows2, colums2);
// Print2DArray(matrix2);


// int[,] resultMatrices = new int[rows, colums2];
// MultiplOfTwoMatrix(matrix, matrix2, resultMatrices);
// Console.WriteLine($"Произведение двух матриц: ");
// Print2DArray(resultMatrices);


// // Чтение данных из консоли
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }
// // метод генерации двумерного массива 
// int[,] Gen2DArray(int xlen, int ylen)
// {
//     int[,] arr = new int[ylen, xlen];
//     for (int i = 0; i < ylen; i++)
//     {
//         for (int j = 0; j < xlen; j++)
//         {
//             arr[i, j] = j + i;
//         }
//     }
//     return arr;
// }
// int[,] Gen2DArray2(int xlen2, int ylen2)
// {
//     int[,] arr2 = new int[ylen2, xlen2];
//     for (int i = 0; i < ylen2; i++)
//     {
//         for (int j = 0; j < xlen2; j++)
//         {
//             arr2[i, j] = j + i;
//         }
//     }
//     return arr2;
// }

// // Печать двумерного массива
// void Print2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }



// // if (matrix.GetLength(0) != matrix2.GetLength(1))
// {
//     Console.WriteLine(" Матрицы нельзя перемножить ");
//     return;
// }
// // метод перемножения двух матриц
// void MultiplOfTwoMatrix(int[,] matrix, int[,] matrix2, int[,] resultMatrices)
// {

//     for (int i = 0; i < resultMatrices.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultMatrices.GetLength(1); j++)
//         {
//             int sum = 0;
//             if (matrix.GetLength(0) != matrix2.GetLength(1))
//             {
//                 Console.WriteLine(" Матрицы нельзя перемножить ");
//                 return;
//             }

//             for (int k = 0; k < matrix.GetLength(1); k++)

//             {
//                 sum += matrix[i, k] * matrix2[k, j];
//             }
//             resultMatrices[i, j] = sum;
//         }
//     }
// }