/*
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N (N >= M):");
int N = Convert.ToInt32(Console.ReadLine());
if (N >= M)
    Console.WriteLine($"Сумма чисел в промежутке [{M},{N}]: {SumMtoN(M,N)}");
if (N < M)
    Console.WriteLine($"Нарушено условие: M >= N");
int SumMtoN(int M, int N)
{
    if (M==N) return M;
    return M + SumMtoN(M+1,N);
}