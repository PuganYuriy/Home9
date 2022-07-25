// Урок 9. Как не нужно писать код. Часть 3
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// string printNumberRecusive(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     else
//     {
//         return start + ", " + printNumberRecusive(start+1,end);
//     }
// }
// Console.Clear();
// Console.Write("Введите значение М: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if (M < N)
// {
//     Console.Write($"M = {M}; N = {N} -> ");
//     Console.WriteLine($"{printNumberRecusive(M,N)}");
// }
// if (N < M)
// {
//     Console.Write($"N = {N}; M = {M} -> ");
//     Console.WriteLine($"{printNumberRecusive(N,M)}");
// }
// else
// {
//     Console.Write($"числа равны");
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sumNumberRecusive(int start, int end)
{
    int sum = 0;
    if (start == end)
    {
        return start;
    }
    else
    {
        return start + sumNumberRecusive(sum + start+1, end);
    }
}
Console.Clear();
Console.Write("Введите значение М: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int B = Convert.ToInt32(Console.ReadLine());

if (A < B)
{
    Console.Write($"M = {A}; N = {B} -> ");
    Console.WriteLine($"{sumNumberRecusive(A,B)}");
}
if (B < A)
{
    Console.Write($"N = {B}; M = {A} -> ");
    Console.WriteLine($"{sumNumberRecusive(B,A)}");
}
else
{
    Console.Write(" ");
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29