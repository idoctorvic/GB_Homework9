﻿//  Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumbers(number, 1));
string PrintNumbers(int start, int end)
{
	if (number == 1)
	{
		return number.ToString();
	}
	return(number + " " + PrintNumbers(--number, 1));
}
