/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.Clear();
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Задайте размер массива: ");
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); ++i)
{
    for (int j = 0; j < array.GetLength(1); ++j)
    {
        for (int l = j+1; l < array.GetLength(1); l++)
        {
            if (array[i, j] < array[i, l])
            {
                int temp = array[i, j];
                array[i, j] = array[i, l];
                array[i, l] = temp;
            }
        }
    }    
}
Console.WriteLine("Отсортированный массив (элементы в строках упорядоченны по убыванию):");
PrintArray(array);
Console.WriteLine();


//////////////////////////////////////////////////////////////////////////////////////
/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */

/* Console.Clear();
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Задайте размер массива: ");
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Сумма элементов по строкам:");
int[] arraySum = new int[rows];
int k = 0;
int min = columns*int.MaxValue;
int stroka=0;
for (int i = 0; i < array.GetLength(0); ++i)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); ++j)
    {
        sum = sum + array[i, j];
    }
    k++;
    Console.WriteLine(k + " = " + sum);
    arraySum[i] = sum;
    if (arraySum[i] < min)
    {
        min = arraySum[i];
        stroka=i+1;
    }
}
Console.WriteLine();
Console.WriteLine("Минимальная сумма элементов по строкам  равна " + min + "  и принадлежит " + stroka + " строке."); */


/////////////////////////////////////////
/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

/* Console.Clear();
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Необходимо найти произведение двух матриц.");
Console.WriteLine();
Console.WriteLine("Задайте размер первой матрицы: ");
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Задайте размер второй матрицы: ");
Console.Write("Введите количество строк: ");
int rows2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns2 = int.Parse(Console.ReadLine());
Console.WriteLine();
while (columns != rows2)
{
    Console.WriteLine("Для расчета произведения двух матриц, число строк второй матрицы должно быть равно количеству столбцов первой матрицы");
    Console.WriteLine("Введите, пожалуйста, корректно количество строк второй матрицы: ");
    rows2 = int.Parse(Console.ReadLine());
}
int[,] arrayA = GetArray(rows, columns);
int[,] arrayB = GetArray(rows2, columns2);
Console.WriteLine();
int[,] arrayC = GetArray(arrayA.GetLength(0), arrayB.GetLength(1));
Console.WriteLine("Первая матрица: ");
PrintArray(arrayA);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintArray(arrayB);
Console.WriteLine();
for (int i = 0; i < arrayA.GetLength(0); ++i)
{
    for (int j = 0; j < arrayB.GetLength(1); ++j)
    {
        int sum = 0;
        for (int l = 0; l < arrayA.GetLength(1); ++l)
        {
            sum += arrayA[i, l] * arrayB[l, j];
        }
        arrayC[i, j] = sum;
    }
}
Console.WriteLine("Произведение двух матриц: ");
PrintArray(arrayC);
Console.WriteLine(); */


//////////////////////////////////////////////////////////////

/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


/* Console.Clear();
Console.WriteLine("Задайте размер трехмерного массива: ");
Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите Z: ");
int z = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,,] array = new int[x, y, z];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = new Random().Next(10, 100);
            int temp = Number(i, j, k, array);
            while (temp == 1)
            {
                array[i, j, k] = new Random().Next(10, 100);
                temp = Number(i, j, k, array);
            }
        }
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k +")"+" " );
        }
        Console.WriteLine();
    }
}

int Number(int a, int b, int c, int[,,] array2)
{
    int temp = 0;
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(2); k++)
            {
                if (i == a && j == b && k == c)
                {
                    continue;
                }
                if (array2[a, b, c] == array2[i, j, k])
                {
                    temp = 1;
                    return temp;
                }
            }
        }
    }
    return temp;
}
Console.WriteLine(); */


///////////////////////////////////////////////////////////
/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

/* Console.Clear();
int n = 4;
int step = 1;
int[,] spir = new int[n, n];
Console.WriteLine("Задан массив размером 4*4, изначально заполнен 0, далее заполняется по спирали от 1 до 16: ");
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintArray(spir);
for (int j = 0; j < spir.GetLength(1); j++)
{
    spir[0, j] = step;
    step++;
}
for (int  i = 1; i < spir.GetLength(0); i++)
{
    spir[i, spir.GetLength(0) - 1] = step;
    step++;
}
for (int  j = 2; j >= 0; j--)
{
    spir[spir.GetLength(0) - 1, j] = step;
    step++;
}
for (int  i = 2; i > 0; i--)
{
    spir[i, 0] = step;
    step++;
}
for (int  j = 2; j < spir.GetLength(1) - 2; j++)
{
    spir[spir.GetLength(0) - 3, j] = step;
    step++;
}
for (int  j = 1; j < spir.GetLength(1) - 1; j++)
{
    spir[spir.GetLength(0) - 3, j] = step;
    step++;
}
for (int j = 2; j > 0; j--)
{
    spir[spir.GetLength(0) - 2, j] = step;
    step++;
}

Console.WriteLine();
Console.WriteLine("Заполненный массив:");
PrintArray(spir);
Console.WriteLine(); */