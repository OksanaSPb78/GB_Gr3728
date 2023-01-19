//      ЗАДАЧА 11
// Напишите программу, которая выводит случайное трёхзначное число и удаляет
// вторую цифру этого числа

// //      ВАРИАНТ 1
// // Создание обьекта рэндом
// System.Random numSintezator = new System.Random();
//  // Ввод численной переменной
//  int num = numSintezator.Next(100, 1000);
//  //  Ввод трёхзначного случайного числа
// Console.WriteLine(num);
// // Получим первую цифру из трёхзначного числа
// int digitFirst = num/100;
// // Получим вторую цифру из трёхзначного числа
// int digitLast = num%10;
// // Соберём из полученных двух цифр число
// Console.WriteLine(digitFirst*10+digitLast);

// ВАРИАНТ 2 
// Создадим объект random
System.Random random = new System.Random();
// Получим рэндомное число
int randomNumber = random.Next(100,1000);
// Печатаем число, чтобы его увидел пользователь
Console.WriteLine("Число: " +randomNumber);
// Превращаем это число в строку
string value = randomNumber.ToString();
// Превращаем его из строки в массив char
char[]numberArray = value.ToCharArray();
// Выводим первую и последнюю цифры трёхзначного числа
Console.WriteLine(numberArray[0]+""+numberArray[2]);

