// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter a number to start from: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number to finish with: ");
int endNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"The summ is {Summ(startNumber, endNumber)}");

int Summ(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return(start + Summ(start + 1, end));
}