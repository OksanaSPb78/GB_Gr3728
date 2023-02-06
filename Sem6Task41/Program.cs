
// Задача 41:
// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за 
// нажатиями с клавиатуры и выдает сколько чисел больше 0 было введено.


// просим пользователя ввести числа
Console.Write("Введите числа через запятую: ");
// создаем переменную, куда передадим данные от пользователя в виде массива
int[] numbers = StringToNum(Console.ReadLine() ?? "0");
// объявим метод печати массива входных чисел
PrintArray(numbers);
// создаем переменную, где сложим значения >0
int sum = 0;
// циклом проходим по всем заданным числам, которые >0
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");

// метод перевода символов в массив
int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int[count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input[i] != ',')
        {
            if (i != input.Length - 1)
            {
                temp += input[i].ToString();
                i++;
            }
            else
            {
                temp += input[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}

// метод вывода массива пользователю
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


