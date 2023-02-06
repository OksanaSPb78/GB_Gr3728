// Задача 38:
//  Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76



// //   вариант 2
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

// ВАРИАНТ 2 не решен!!

//Универсальный метод генерации масс
int[] Gen1DArr(int len, int minValue, int maxValue)
{
    //создадим объект ,создающий случайные значения
    Random rnd = new Random();
    // создаем сам массив
    int[] arr = new int[len];

    //в цикле for проходим все элементы массива
    for (int i = 0; i < arr.Length; i++)
    {
        //заполняем массив мин и макс значениями
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    //выдаем массив на выход
    return arr;
}
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// int max=0;
// int min=0;

// метод нахождения разницы между максимальным и минимальным элементами массива
int MinMax(int[] arr)
{
    int max = int.MinValue;
    int min = int.MaxValue;


    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min)
            min = arr[i];
    }
    return (max - min);
}
// //метод печати массива PrintData
// void PrintData(string res, int value)
// {
//     Console.WriteLine(res + value);
// }
int[] difMaxFromMin = Gen1DArr(5, 1, 100);
MinMax(difMaxFromMin);
Print1DArr(difMaxFromMin);
// PrintData(difMaxFromMin);