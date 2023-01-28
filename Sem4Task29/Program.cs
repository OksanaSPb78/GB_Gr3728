//    Задача 29 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//* Ввести с клавиатуры длину массива и диапазон значений элементов
//*Дополнительно: Написать программу которая из имен через запятую выберет случайное
//имя и выведет в терминал
//Игорь, Антон, Сергей -> Антон
//Подсказка: Для разбора строки использовать метод string.split(). Для выбора
//случайного имени метод Random.Next(1,<длина массива имен>+1). 

// ВАРИАНТ 1
//Метод читает данные от пользователя
int ReadData(string msg)
{
    // Просим ввести данные
    Console.WriteLine(msg);
    // Вводим переменную с проверкой на null
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод генерации массива из 8 элементов
int[] Gen1DArr(int num, int len)
{
    Random rnd = new Random();
    int[] arr = new int[8];
    // Создадим генератор массива
    for (int i = 0; i < arr.Length; i++)
    {
        //обратимся к каждому элементу массива
        arr[i] = rnd.Next(0, 2);
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
int[] arr = Gen1DArr(0, 2);
Print1DArray(arr);




