//Задача №30 универсальная без подсчета элементов (рандом)
//Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.


//Метод читает данные от пользователя
int ReadData(string msg)
{
    // Просим ввести данные
    Console.WriteLine(msg);
    // Вводим переменную с проверкой на null
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод генерации массива универсальный (для любого числа)
int[] Gen1DArr(int num, int begin, int end)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    // Создадим генератор массива
    for (int i = 0; i < arr.Length; i++)
    {
        //обратимся к каждому элементу массива
        arr[i] = rnd.Next(begin, end);
    }

    return arr;
}

// Метод печати одномерного массива
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
int arrLen = ReadData("Введите длину массива: ");
int[] arr = Gen1DArr(arrLen, 0, 2);
Print1DArray(arr);




