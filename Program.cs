﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ($"Число {a} в степени {b} = {GetExp(a)}");

// //Метод
// int GetExp(int a) {
// int Exp = 1;
//     for (int i = 1; i <= b; i++) {
//     Exp = Exp * a;
//     }
//     return Exp;
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()!);
// int count = GetCount(number);
// Console.WriteLine($"Cумма цифр числа {number} = {GetSum(number)}");

// // Кол-во цифр
// int GetCount(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }

// // Сумма
// int GetSum(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= count; i++)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     return sum;
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array = GetRange(8);
Console.WriteLine($"[{String.Join(",", array)}]");

//method
int[] GetRange(int size){
int[] massive = new int[size];
for(int i = 0; i < massive.Length; i++){
massive[i] = new Random().Next(1,100);
}
return massive;
}