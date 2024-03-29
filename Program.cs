﻿// Напишите программу, которая на вход принимает 
// целое число N, а на выходе показывает все целые 
// числа в промежутке от -N до N.

// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

Console.WriteLine("Введите целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0) // Провека на положительность чиисла (число > 0)
{
    int count = -n; // Счетчик

    while (count <= n)
    {
        Console.Write(count + " "); // Write выведет все в одну строку, а WriteLine выведет все в один ряд(т.е. после каждого вывода будет переходить на новую строку)
        count = count + 1;
    }
}
else
{
    Console.WriteLine("Введено некорректное число. Читай внимательней условие задачи!");
}