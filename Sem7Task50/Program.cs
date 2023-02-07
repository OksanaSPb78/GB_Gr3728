
// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

//1) Получение размерности матрицы
int xlen = ReadData("Введите число столбцов: ");
int ylen = ReadData("Введите число строк: ");
int element = ReadData("Введите число  ");

//2) Генерация двумерного массива
int[,] matrix = Gen2DArr(xlen, ylen);

//3) Печатаем двумерный массив
Print2DArr(matrix);

SearchElement(matrix, element);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    // Вводим переменную с проверкой на null
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

// метод печати двумерного массива
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine(" ");
    }
}

// метод поиска элемента в двумерном массиве
void SearchElement(int[,] arr, int element)
{
bool elementFind = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (element == arr[i, j])
            {
                Console.WriteLine(element +  "Найден элемент " + i + j);
                elementFind = true;
            }
        }
        if (elementFind == false)
        {
            Console.WriteLine(element +  "Такого элемента нет ");
        }
    }

}
