﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите b1 (для прямой y = k1 * x + b1):");
double b1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите k1 (для прямой y = k1 * x + b1):");
double k1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите b2 (для прямой y = k2 * x + b2):");
double b2 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите k2 (для прямой y = k2 * x + b2):");
double k2 = Convert.ToInt32 (Console.ReadLine());

double resX = (b2-b1)/(k1-k2);
double resY = k1*resX + b1;

Console.WriteLine("("+resX+"; "+resY+")");