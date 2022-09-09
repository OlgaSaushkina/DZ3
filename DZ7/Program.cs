//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Clear();
double[,] GetArray(int m, int n) 
{
  double[,] result = new double[m, n];
  for (int i = 0; i < m; ++i) 
  {
    for (int j = 0; j < n; ++j) 
    {
      result[i, j] = new Random().NextDouble()*30-10;
    }
  }
  return result;
}
void PrintArray(double[,] array) 
{
  for (int i = 0; i < array.GetLength(0); ++i) 
  {
    for (int j = 0; j < array.GetLength(1); ++j) 
    {
      Console.Write(array[i, j] + "  ");
    }
    Console.WriteLine();
  }
}
Console.WriteLine("Задайте размер массива: ");
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetArray(rows, columns);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); ++i) 
{
    for (int j = 0; j < array.GetLength(1); ++j)
    {
        array[i,j]=Math.Round(array[i,j], 1);               
    }
}
PrintArray(array);
Console.WriteLine();

/////////////////////////////////////////


//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


/* Console.Clear();
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            result[i, j] = new Random().Next(0, 21);
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
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine();
int flag=0;
for (int i = 0; i < array.GetLength(0); ++i)
{
    for (int j = 0; j < array.GetLength(1); ++j)
    {      
        if (num ==array[i,j]){
            flag =1;
            break;
        }                           
    }  
}
if(flag==1)
{
   Console.WriteLine(num + " -> такое число есть в массиве."); 
} 
if(flag==0)
{
   Console.WriteLine(num + " -> такого числа нет в массиве.");    
}   
    
Console.WriteLine(); */



///////////////////////////////////////////////////////////
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
Console.WriteLine("Задайте размер массива: ");
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое элементов по столбцам:");
for (int j = 0; j < array.GetLength(1); ++j)
{
    double sum=0;
    for (int i = 0; i < array.GetLength(0); ++i)
    {      
        sum=sum+array[i,j];            
    }   
double sredarif=sum/(array.GetLength(0));  
Console.Write( + sredarif+ "  ");
}  
Console.WriteLine();  */

