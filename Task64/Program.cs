/*
Задача 64: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int i=0;
Console.WriteLine($"Натуральные числа в промежутке от [{N},1]:{NNum(N,i)}");

string NNum(int N, int i)
{
    if (i==N) return "";
    return NNum(N,i+1) + " " + Convert.ToString(i+1) ;
}
