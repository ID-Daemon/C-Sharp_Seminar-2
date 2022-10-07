// int number = new Random().Next(10,100);
// Console.WriteLine(number);
// int firstNumber;
// int secondNumber =  number % 10;
// firstNumber = (number - secondNumber) / 10;
// Console.WriteLine(firstNumber);
// Console.WriteLine(secondNumber);


// 1) выводит случайное трехзначное число и удаляет вторую цифру числа

// 2) принимает два числа, и проверяет кратность второга числа первому, если не кратное показывает остаток от деления.
Console.WriteLine();
Console.WriteLine("Первое задание.");
Console.WriteLine();

int number = new Random().Next(100,1000);
Console.WriteLine($"Загадано число {number}");
Console.WriteLine();

int number1, number2, number3;
number3 = number % 10;
number2 = (number / 10) % 10;
number1 = number / 100;
Console.WriteLine($"Перое число = {number1}, второе число = {number2}, третье число = {number3}");
int finalNumber = number1 * 10 + number3;
Console.WriteLine($"Итоговое число = {finalNumber}");

Console.WriteLine();Console.WriteLine();
// Второе задание 
Console.WriteLine("Второе задание.");
Console.WriteLine();

Console.Write("Введите первое число:");
number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
number2 = int.Parse(Console.ReadLine()!);

if (number1 % number2 != 0) {
    Console.WriteLine("Остаток от деления первого числа на второе равен: " + number1 % number2);
} else Console.WriteLine($"Первое число({number1}) кратно второму числу({number2})");

// 3) Проверка кратности на 7 и 23 значения на входе

// 4) Принимает на вход два числа и проверяет является ли второе число квадратом первого

Console.WriteLine();Console.WriteLine();
// Третье задание 
Console.WriteLine("Третье задание.");
Console.WriteLine();

Console.WriteLine("Введите число");
number = int.Parse(Console.ReadLine()!);

if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("Введенное число кратно 7 и 23");
else Console.WriteLine("Введенное число НЕ кратно 7 и 23");

Console.WriteLine();Console.WriteLine();
// Четвертое задание 
Console.WriteLine("Четвертое задание.");
Console.WriteLine();

Console.Write("Введите первое число:");
number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
number2 = int.Parse(Console.ReadLine()!);

if ((number2 * number2) != number1 || (number1 * number1) != number2) Console.WriteLine("Одно из чисел является квадратом другого числа");
else Console.WriteLine("Числа не являются квадратом друг-друга");


// //Переменные для ДЗ
// // int number;

// // Домашнее задание

// Console.WriteLine();Console.WriteLine();
// Console.WriteLine("Задача №10.");
// Console.WriteLine();

// Console.Write("Введите трехзначное число: ");
// number = int.Parse(Console.ReadLine()!);
// while (number < 100 || number > 999){
//     Console.Write("Вы ввели НЕ трехзначное число. Пожалуйста, введите корректное число: ");
//     number = int.Parse(Console.ReadLine()!); 
// }

// number2 = (number / 10) % 10;
// Console.WriteLine($"Втрорая цифра введенного числа {number} - {number2}");

// Console.WriteLine();Console.WriteLine();
// Console.WriteLine("Задача №13.");
// Console.WriteLine();

// // По идее я написал обработку числа до трехзначного, поэтому ограничение числа до 100.000 не актуально.
// // do {
//     Console.Write("Введите число: ");
//     number = int.Parse(Console.ReadLine()!);
// // } while (number > 100000);

// while (number > 999) {
//     if (number < 100) break;
//     number = number / 10;
// } 

// if (number < 100) Console.WriteLine("Третьей фифры нет");
// else Console.WriteLine("->" + number % 10);

// Console.WriteLine();Console.WriteLine();
// Console.WriteLine("Задача №15.");
// Console.WriteLine();

// Console.Write("Введите номер дня недели: ");
// number = int.Parse(Console.ReadLine()!);

// if (number < 1 || 7 < number) Console.WriteLine("Нет такого номера недели");
// else if (number == 6 || number == 7) Console.WriteLine("Вы ввели номер выходного дня недели");
// else Console.WriteLine("Это не выходной");