// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());

if (b == a * a)
{ 
    Console.WriteLine("второе число является квадратом первого числа");
}
else {
    Console.WriteLine("второе число не является квадратом первого числа");
}

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое целое число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе целое число");
// int b = Convert.ToInt32(Console.ReadLine());

// if (b > a)
// { 
//     Console.Write("max = ");
//     Console.WriteLine(b);
// }
// else {
//     Console.Write("max = ");
//     Console.WriteLine(a);
// }

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите цифровое обозначение дня недели");
// int day = Convert.ToInt32(Console.ReadLine());


// if (day >= 1 && day <= 5)
// { 
//     Console.WriteLine("не выходной день");
// }

// else if (day >= 6 && day <= 7)
// { 
//     Console.WriteLine("выходной день");
// }
// else {
//     Console.Write("дней недели всего 7, введите число от 1 до 7");
//     }

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите целое число, чтобы определить его четность");
// int number = Convert.ToInt32(Console.ReadLine());


// if (number % 2 == 0)
// { 
//     Console.WriteLine("да, число четное");
// }

// else {
//     Console.Write("нет, число нечетное");
//     }