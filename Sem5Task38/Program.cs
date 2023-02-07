// Задача 38:
//  Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76



// //   вариант 1

//Универсальный метод генерации массива одномерного
double[] Gen1DArr(int len, int minValue, int maxValue)
{
    //создадим объект ,создающий случайные значения
    Random rnd = new Random();
    // создаем сам массив
    double[] arr = new double[len];

    //в цикле for проходим все элементы массива
    for (int i = 0; i < arr.Length; i++)
    {
        //заполняем массив мин и макс значениями вещественных чисел
        arr[i] = new Random().Next(minValue, maxValue + 1)+ new Random().NextDouble();
    }
    //выдаем массив на выход
    return arr;
}
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// метод нахождения разницы между максимальным и минимальным элементами массива
double MinMax(double[] arr)
{
    double max = int.MinValue;
    double min = int.MaxValue;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return (max - min);
}

double[] difMaxFromMin = Gen1DArr(100, 1, 100);
Print1DArr(difMaxFromMin);
double conveArr = MinMax(difMaxFromMin);
Console.WriteLine(conveArr);
// Print1DArr(difMaxFromMin);

// // создаем размер массива
// int size = 5;
// // выделяем место под новый массив со случайными числами
// int[] numbers = new int[size];
// // создаем метод случайных чисел
// AllArrayRandomNumbers(numbers);
// // метод вывода на печать массива
// PrintArray(numbers);
// // вводим переменные минимум и м максимум
// int max = numbers[0];
// int min = numbers[0];
// // циклом проходим по массиву и находим мин и макс значения
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)
//     {
//         max = numbers[i];
//     }
//     else if (numbers[i] < min)
//     {
//         min = numbers[i];
//     }
// }
// // выводим на консоь
// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"Минимальное число: {max}");
// Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");


// // метод создания массива из случайных чисел в диапазоне от 1 до 100
// void AllArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
// }

// // метод печати массива
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
