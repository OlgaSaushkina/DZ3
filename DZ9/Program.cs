/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */

Console.Clear();
Console.WriteLine("Введи натуральные числа M и N:");
Console.Write("Введи M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введи N: ");
int n = int.Parse(Console.ReadLine());
while (m <= 0 || n <= 0)
{
    Console.WriteLine("Числа M и N должны быть больше 0:");
    Console.Write("Введи M: ");
    m = int.Parse(Console.ReadLine());
    Console.Write("Введи N: ");
    n = int.Parse(Console.ReadLine());
}
Console.WriteLine("Все натуральные числа в промежутке от M до N:");
void Numbers(int m, int n)
{
    int m1 = m;
    int n1 = n;
    if (m > n)
    {
        m1 = n;
        n1 = m;
    }
    for (int i = m1; i <= n1; i++)
    {
        Console.Write(i + ", ");
    }
}
Numbers(m, n);

////////////////////////////////////////////////////

/*  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
/* Console.Clear();
Console.WriteLine("Введи натуральные числа M и N:");
Console.WriteLine();
Console.Write("Введи M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введи N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
while (m <= 0 || n <= 0)
{
    Console.WriteLine("Числа M и N должны быть больше 0:");
    Console.Write("Введи M: ");
    m = int.Parse(Console.ReadLine());
    Console.Write("Введи N: ");
    n = int.Parse(Console.ReadLine());
}
int SummNumbers(int m, int n)
{
    int m1 = m;
    int n1 = n;
    if (m > n)
    {
        m1 = n;
        n1 = m;
    }
    return (n1 + m1) * (n1 - m1 + 1) / 2;
}
Console.Write("Сумма натуральных элементов от M до N -> :  ");
Console.WriteLine(SummNumbers(m, n));
Console.WriteLine(); */



//////////////////////////////////////////
/* 
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */


/* Console.Clear();
Console.WriteLine("Введи два неотрицательных числа m и n");
Console.WriteLine();
Console.Write("Введи m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введи n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
while (m < 0 || n < 0)
{
    Console.WriteLine("Числа m и n должны быть больше 0:");
    Console.Write("Введи m: ");
    m = int.Parse(Console.ReadLine());
    Console.Write("Введи n: ");
    n = int.Parse(Console.ReadLine());
}


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
Console.Write("Вычисление функции Аккермана по задданым параметрам равно -> ");
Console.WriteLine(Akkerman(m, n)); */