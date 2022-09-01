// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int AckermanFunction(int firstNumbers, int secondNumbers)
{
    if (firstNumbers == 0) return secondNumbers + 1;
    if (firstNumbers > 0 & secondNumbers == 0) return AckermanFunction(firstNumbers - 1, 1);
    return AckermanFunction(firstNumbers - 1, AckermanFunction(firstNumbers, secondNumbers - 1));
}
Console.Write("Введите значение первого числа: ");
int numbersFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение первого числа: ");
int numbersSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана({numbersFirst},{numbersSecond}) = {AckermanFunction(numbersFirst, numbersSecond)}");