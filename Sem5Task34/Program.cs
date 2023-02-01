// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// ВАРИАНТ 1
// метод печати массива
void PrintData(string res)
{
    Console.WriteLine(res);
}

// метод генерации массива случайными числами
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        // заполним массив минимальными и максимальными значениями
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

//  метод печати массива с квадратными скобками вначале и конце([]) 
// и зяпятой (,) между числами
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// метод подсчёта количества четных элементов в массиве через сокращенный метод Test
int CountElem(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}
// Рекрусия метода подсчета
bool Test(int n)
{
    return (n%2==0);
}
// вызов программы (четыре случайных трёхзначных числа)
int[] testArr = Gen1DArray(4,100,1000);
// печать метода TestArr
Print1DArr(testArr);
int count = CountElem(testArr);
// вывод значения на консоль
PrintData("Количество чётных чисел в заданном массиве:"+count);