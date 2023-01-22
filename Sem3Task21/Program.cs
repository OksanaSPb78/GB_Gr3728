//   Задача 21
//Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// //  ВАРИАНТ 1
// // Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     // Просим ввести координаты х
//     Console.WriteLine(msg);
//     // Вводим переменную x с проверкой на null
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// // Метод вывода результата пользователю
// void PrintData(string msg, double res)
// {
//     Console.WriteLine(msg + res);
// }
// // Метод вычисления расстояния в 3D пространстве между точками
// double CulcLen(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     double res = 0;
//     // Квадрат гипотинузы (теорема Пифагора)
//     res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2));
//     return res;
// }
// // Вводим координаты точек
// int coordX1 = ReadData("Введите координату Х1");
// int coordX2 = ReadData("Введите координату Х2");
// int coordY1 = ReadData("Введите координату Y1");
// int coordY2 = ReadData("Введите координату Y2");
// int coordZ1 = ReadData("Введите координату Z1");
// int coordZ2 = ReadData("Введите координату Z2");

// // Вычисляем длинну
// double len = CulcLen(coordX1, coordX2, coordY1, coordY2, coordZ1, coordZ2);
// // Выдаем результат
// PrintData("Расстояние между точками: ", len);


// ВАРИАНТ 2
// Метод читает данные от пользователя
int ReadData(string msg)
{
    // Просим ввести координаты х
    Console.WriteLine(msg);
    // Вводим переменную x с проверкой на null
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод вывода результата пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}
// Метод вычисления расстояния в 3D пространстве между точками
double CulcLen(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double res = 0;
    // Квадрат гипотинузы (теорема Пифагора)
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    return res;
}
PrintData("Расстояние между точками: ", CulcLen(
    ReadData("Введите координату X1"),
    ReadData("Введите координату X2"),
    ReadData("Введите координату Y1"),
    ReadData("Введите координату Y2"),
    ReadData("Введите координату Z1"),
    ReadData("Введите координату Z2")));
