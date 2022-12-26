// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение m = ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите значение n = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($" -> " + SumFromMtoN(M, N));

int SumFromMtoN(int A, int B)
{
    if (A < B) return A + SumFromMtoN(A + 1, B);
    else return A;
}
