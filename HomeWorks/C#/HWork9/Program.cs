
/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
/*
void Num(int n) {
    Console.Write(n + " ");
    if (n > 1) {
        Num(n - 1);
    }
}
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Num(n);
if (n < 0) {
Console.Write("Вы ввели отрицательное значение N!");
}
*/


/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
/*
void RangeNumbers(int m, int n) {
    if (n > m) { 
        RangeNumbers(m, n - 1);
        Console.Write(n + " ");
    }
    if (m > n) {
        RangeNumbers(n, m - 1);
        Console.Write(m + " ");
    }
    if (m == n) {
        Console.Write(m + " ");
    }
}
int SumDigits(int min, int max) {

    if (min > max)
        return min + SumDigits(min - 1, max);
    if (min < max)
        return min + SumDigits(min + 1, max);
    else
        return min;
}
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

RangeNumbers(m, n);
int result = SumDigits(m, n);

Console.WriteLine();
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {result}");
*/

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

/*
int A(int m, int n) {
    if (m == 0)
        return n + 1;
    if ((m != 0) && (n == 0))
        return A(m - 1, 1);
    if ((m != 0) && (n !=0))
      return A(m - 1, A(m, n - 1));
    return A(m, n);
}
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = {A(m, n)}");
*/