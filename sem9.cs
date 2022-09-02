//Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N.

// Console.Clear();
// Console.Write("Введите N: ");
// int n=int.Parse(Console.ReadLine());

// Console.WriteLine(PrintNumbers(1,n));

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }





// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// int PrintNumbers(int start, int end)
// {
//     Console.Write($"{start} ");
//     if (start == end) return start;
//     return  PrintNumbers(start + 1, end);
// }

// Console.Clear();
// Console.Write("Введите M: ");
// int numberM=int.Parse(Console.ReadLine()!);
// Console.Write("Введите N: ");
// int numberN=int.Parse(Console.ReadLine()!);

// PrintNumbers(numberM,numberN);





// // Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// // 453 -> 12
// // 45 -> 9

// string PrintNumbers(int start,int sum)
// {
//     sum += start%10;
//     if (start == 0) return sum.ToString();
//     return (PrintNumbers(start/10,sum));
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int start = int.Parse(Console.ReadLine()!);

// int sum = 0;
// Console.WriteLine("Сумма равно:" + PrintNumbers(start,sum));





// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.Write("Введите базовое Число: ");
// int baseVal = int.Parse(Console.ReadLine());

// Console.Write("Введите степень Число: ");
// int exp = int.Parse(Console.ReadLine());

// int power(int baseValue, int exp) {
//     if (exp == 0) {
//         return 1;
//     } else {
//         return  baseValue * power(baseValue, exp -1);
//     }
// }
// Console.Write("В степен: " + power(baseVal, exp));





// Добрый день всем. Полезные ссылки на ресурсы и дополнительные материалы, которые могут быть вам полезны.

// Гарвардский курс CS50
// https://habr.com/ru/company/vertdider/blog/403823/

// Алгоритмы и структуры данных
// https://www.youtube.com/c/pavelmavrin

// Интерактивный учебник по C#
// https://ulearn.me/course/basicprogramming/69a2e121-e58f-4cd0-8221-7affb7dc796e

// Задания на сайтах (челленджи, олимпиады, батлы)
// https://leetcode.com
// https://codeforces.com/catalog или https://codeforces.com/problemset
// https://app.codesignal.com/login
// https://www.videosharp.info/console/book

// Видео-уроки по созданию игр на C#
// https://www.youtube.com/c/DebroneConstant/videos

// Статья от разработчика про привычки, которые помогут начинающим программистам быстрее влиться в работу и продвинуться в карьере (на англ).
// https://www.freecodecamp.org/news/good-habits-for-junior-developers/

// https://habr.com/ru/post/200758/ или https://russianblogs.com/article/1115865913/ или https://www.evkova.org/esse/klassicheskaya-zadacha-hanojskaya-bashnya

// https://habr.com/ru/post/275813/