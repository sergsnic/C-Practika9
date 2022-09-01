// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumValues(int numbersFirst, int numbersSecond)
{
    if (numbersFirst == numbersSecond) return numbersSecond;
    return numbersFirst + SumValues(numbersFirst + 1, numbersSecond);
}

Console.Write("Введите значение первого числа: ");
int numbersFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение первого числа: ");
int numbersSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumValues(numbersFirst, numbersSecond));