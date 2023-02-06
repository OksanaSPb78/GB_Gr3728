// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите 
// сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
// метод подсчёта суммы элементов массива, стоящих на нечётных позициях
int SumPos(int[] arr)
{
    // объявим переменную 
    int res = 0;
    int i = 0;
    // через цикл пройдёмся по массиву и найдём элементы, стоящиеи на нечётных позициях
    for (i = 1; i < arr.Length; i++) 
    //// наполним результат суммой  найденных элементов
    if (i % 2 != 0)
    //// {
    res += arr[i];
    //// }

    return res;

}
// вызов программы
int[] testArr = Gen1DArray(4, -5, 90);
// вызов метода подсчета и в него передать массив testArr
int count = SumPos(testArr);
// напечатаем
Print1DArr(testArr);

// вывод значений на консоль
PrintData("Сумма элементов массива,стоящих на нечётных позициях равна:"+count);
