﻿//            Задача 9 
// Напишите программу, которая выводит случайное число на отрезок [10;99]
// и показывает наибольшую цифру числа.

// //  ВАРИАНТ 1
// / Генерация случайного числа
// System.Random numSintezator = new System.Random();
// // Ввод численной переменной
// int rndNum = numSintezator.Next(10, 100);
// // Напечатаем это число
// Console.WriteLine("Случайное число:" + rndNum);
// // Разобьем случайное число на первую и вторую цифры
// int digit1 = rndNum / 10;
// int digit2 = rndNum % 10;
// // Сравним ,полученные при разделении, два числа
// if (digit1 > digit2)
// {
//     Console.WriteLine("Цифра 1 больше цифры 2:" + digit1 + " " + digit2);
// }
// else
// {
//     Console.WriteLine("Цифра 2 больше цифры 1:" + digit1 + " " + digit2);
// }

//    ВАРИАНТ 2

// // Генерация случайного числа
// System.Random numSintezator = new System.Random();
// // Создание массива символов ,превращение числа в строку, разделение чисел и 
// // возврат в виде массива символов 
// char[] digits = numSintezator.Next(10, 100).ToString().ToCharArray();
// // Запись самого случайного числа в строке
// Console.WriteLine(digits);
// // Разделим 2 цифры, преобразуя их в число
// int digit1 = (int)digits[0]-48;
// int digit2 = (int)digits[1]-48;
// // Сравним числа методом тернарного оператора
// int resNum = digit1>digit2?digit1:digit2;
// // ВЫВОД наибольшей цифры случайного числа
// Console.WriteLine(resNum);

//       ВАРИАНТ 3
// Генерация случайного числа
System.Random numSintezator = new System.Random();
// Ввод численной переменной
int rndNum = numSintezator.Next(10, 100);
// ВЫВОД наибольшей цифры случайного числа
Console.WriteLine(rndNum);
// Создадим массив с правильными ответами
int[] indxAnsw = new int[90];
// Заполним массив готовыми ответами под любое число
indxAnsw[0] = 1; indxAnsw[1] = 1; indxAnsw[2] = 2; indxAnsw[3] = 3; indxAnsw[4] = 4; indxAnsw[5] = 5; indxAnsw[6] = 6; indxAnsw[7] = 7; indxAnsw[8] = 8; indxAnsw[9] = 9;
indxAnsw[10] = 2; indxAnsw[11] = 2; indxAnsw[12] = 2; indxAnsw[13] = 3; indxAnsw[14] = 4; indxAnsw[15] = 5; indxAnsw[16] = 6; indxAnsw[17] = 7; indxAnsw[18] = 8; indxAnsw[19] = 9;
indxAnsw[20] = 3; indxAnsw[21] = 3; indxAnsw[22] = 3; indxAnsw[23] = 3; indxAnsw[24] = 4; indxAnsw[25] = 5; indxAnsw[26] = 6; indxAnsw[27] = 7; indxAnsw[28] = 8; indxAnsw[29] = 9;
indxAnsw[30] = 4; indxAnsw[31] = 4; indxAnsw[32] = 4; indxAnsw[33] = 4; indxAnsw[34] = 4; indxAnsw[35] = 5; indxAnsw[36] = 6; indxAnsw[37] = 7; indxAnsw[38] = 8; indxAnsw[39] = 9;
indxAnsw[40] = 5; indxAnsw[41] = 5; indxAnsw[42] = 5; indxAnsw[43] = 5; indxAnsw[44] = 5; indxAnsw[45] = 5; indxAnsw[46] = 6; indxAnsw[47] = 7; indxAnsw[48] = 8; indxAnsw[49] = 9;
indxAnsw[50] = 6; indxAnsw[51] = 6; indxAnsw[52] = 6; indxAnsw[53] = 6; indxAnsw[54] = 6; indxAnsw[55] = 6; indxAnsw[56] = 6; indxAnsw[57] = 7; indxAnsw[58] = 8; indxAnsw[59] = 9;
indxAnsw[60] = 7; indxAnsw[61] = 7; indxAnsw[62] = 7; indxAnsw[63] = 7; indxAnsw[64] = 7; indxAnsw[65] = 7; indxAnsw[66] = 7; indxAnsw[67] = 7; indxAnsw[68] = 8; indxAnsw[69] = 9;
indxAnsw[70] = 8; indxAnsw[71] = 8; indxAnsw[72] = 8; indxAnsw[73] = 8; indxAnsw[74] = 8; indxAnsw[75] = 8; indxAnsw[76] = 8; indxAnsw[77] = 8; indxAnsw[78] = 8; indxAnsw[79] = 9;
indxAnsw[80] = 9; indxAnsw[81] = 9; indxAnsw[82] = 9; indxAnsw[83] = 9; indxAnsw[84] = 9; indxAnsw[85] = 9; indxAnsw[86] = 9; indxAnsw[87] = 9; indxAnsw[88] = 9; indxAnsw[89] = 9;
// Вывод результата
Console.WriteLine(indxAnsw[rndNum-10]);

