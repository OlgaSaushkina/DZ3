/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */

Console.Clear();
Console.WriteLine("Введите натуральные числа M и N:");
Console.WriteLine();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

while ((m > n) || (m <= 0))
{
    if (m>n) {
    Console.WriteLine("Число M должно быть меньше числа N ");
    Console.Write("Введите  число M: ");
    m = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    n = int.Parse(Console.ReadLine());
}
    if (m<=0) {
    Console.WriteLine("Число M должно быть ,больше 0 ");
    Console.Write("Введите  число M: ");
    m = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    n = int.Parse(Console.ReadLine());
}
}

Console.WriteLine();
void Numbers(int m, int n)
{
    if (m == n)
    {
        Console.WriteLine(n);
        return;
    }
    if (m < n)
    {
        Console.Write(m + ", ");
        Numbers(m + 1, n);
    }
}
Console.Write("Все натуральные числа в промежутке от M до N: ");
Numbers(m, n);

////////////////////////////////////////////////////

/*  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


/* Console.Clear();
Console.WriteLine("Введите натуральные числа M и N:");
Console.WriteLine();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

while ((m > n) || (m <= 0))
{
    if (m>n) {
    Console.WriteLine("Число M должно быть меньше числа N ");
    Console.Write("Введите  число M: ");
    m = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    n = int.Parse(Console.ReadLine());
}
    if (m<=0) {
    Console.WriteLine("Число M должно быть ,больше 0 ");
    Console.Write("Введите  число M: ");
    m = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    n = int.Parse(Console.ReadLine());
}
}
Console.WriteLine();
int sum =0;
void SumNumbers(int m, int n, int sum)
{
    if (m == n)
    {
        sum += m;
        Console.WriteLine(sum);
        return;
    }
    if (m < n)
    {
        sum += m;
        SumNumbers(m + 1, n, sum);
    }
}
Console.Write("Сумма всех натуральных чисел в промежутке от M до N: ");
SumNumbers(m, n, sum); */





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