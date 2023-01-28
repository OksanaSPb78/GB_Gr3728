// Задача №31
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.


// ВАРИАНТ 1
//Объявим глобальные переменные
int posetivSum=0;
int negotivSum=0;
//Вызов самой программы
int[] testArr = Gen1DArr(12,-9,9);

//вызов основного метода подсчета и передача в него саму программу
NegPosSum(testArr);
//Напечатаем программу
Print1DArr(testArr);
//Вывод значений на консоль
PrintData("Сумма положительных чисел в массиве: ", posetivSum);
PrintData("Сумма отрицательных чисел в массиве: ", negotivSum);

//метод печати массива PrintData
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

//Универсальный метод генерации массива
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

//метод печати массива PrintData
void Print1DArr(int[] arr)
{
    //печатаем первую квадратную скобку массива ([)
    Console.Write("[");
//проходим циклом по всем элементам массива, кроме одного
    for (int i = 0; i < arr.Length - 1; i++)
    {
    //печать массива с запятой (,)
        Console.Write(arr[i] + ", ");
    }
//печатаем последний элемент массива и последнюю скобку (])
    Console.WriteLine(arr[arr.Length - 1]+"]");
}

////МЕТОД ПОДСЧЁТА негативных(отриц) и позитивных(положит) элементов массива
void NegPosSum(int[] arr) // передаем массив этому методу
{
    //циклом проходим по массиву
    for(int i=0;i<arr.Length;i++)
    {
        if(arr[i]>0)
        {
    //объявим переменную, где складываются положит элементы массива
            posetivSum+=arr[i];
        }
        else
        {
    //объявим переменную, где складываются отриц элементы массива
            negotivSum+=arr[i];
        }

    }
}


// // ВАРИАНТ САВЕЛИЯ

// int InputNum(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// int len = InputNum("Введите длинну массива: ");
// int num1 = InputNum("Введите минимум для значений в массиве: ");
// int num2 = InputNum("Введите максимум для значений в массиве: ");
// Random rnd = new Random();
// int[] createArray(int len)
// {
//     int[] arr = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2));
//     }
//     return arr;
// }
// void showArray(int[] arr)
// {
//     for (int i = 0; i < len; i++)
//     {
//         Console.Write(arr[i] + "\t");
//     }
//     Console.WriteLine(" ");
// }
// int[]arr=createArray(len);
// showArray(arr);
// int Sum(int[] arr, bool MinOrMax){
//     int sum=0;
//     foreach(var i in arr){
//         if ((minOrMax==false)&&(i<0)){
//             sum+=i;
//         }
//         if ((minOrMax==true)&&(i>0)){
//             sum+=i;
//         }
//     }
//     return sum;
// }

// Console.WriteLine("Позитивные "+Sum(arr,true));
// Console.WriteLine("Негативные "+Sum(arr,false));
