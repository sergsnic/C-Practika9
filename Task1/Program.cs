// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

string ListValues(int numbersFirst, int numbersSecond)
{
    if (numbersFirst == numbersSecond) return $"{numbersSecond}";
    return $"{numbersFirst}, " + ListValues(numbersFirst + 1, numbersSecond);
}

Console.Write("Введите значение первого числа: ");
int numbersFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение первого числа: ");
int numbersSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ListValues(numbersFirst, numbersSecond));