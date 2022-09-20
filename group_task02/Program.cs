// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.WriteLine("Введите цифровое обозначение дня недели");
// int day = Convert.ToInt32(Console.ReadLine());


// if (day == 1)
// { 
//     Console.WriteLine("понедельник");
// }

// else if (day == 2)
// { 
//     Console.WriteLine("вторник");
// }
// else if (day == 3)
// { 
//     Console.WriteLine("среда");
// }
// else if (day == 4)
// { 
//     Console.WriteLine("четверг");
// }
// else if (day == 5)
// { 
//     Console.WriteLine("пятница");
// }
// else if (day == 6)
// { 
//     Console.WriteLine("cуббота");
// }
// else if (day == 7)
// { 
//     Console.WriteLine("воскресенье");
// }
// else Console.Write("дней недели всего 7, введите число от 1 до 7");


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите первое целое число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе целое число");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье целое число");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a >= b && a >= c)
// { 
//     Console.Write("max = ");
//     Console.WriteLine(a);
// }

// else if (b >= a && b >= c)
// { 
//     Console.Write("max = ");
//     Console.WriteLine(b);
// }
// else {
//     Console.Write("max = ");
//     Console.WriteLine(c);
// }

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int counter = num - num + 2;
while (counter <= num)
{
Console.Write($"{counter} ");
counter = counter + 2;
}