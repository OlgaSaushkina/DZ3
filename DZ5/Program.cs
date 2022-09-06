//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.Clear(); 
int size = 10;
int[] array = new int[size];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}
Console.Write("Массив: ");
Console.WriteLine(string.Join(", ", array));
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 ==0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine("Количество четных элементов массива равно " + count);
Console.WriteLine();

////////////////////////////////////////////////////////////////////////////////
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0 

/* Console.Clear(); 
int size = 6;
int[] array = new int[size];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 20);
}
Console.Write("Массив: ");
Console.WriteLine(string.Join(", ", array));
for (int i = 1; i < array.Length; i=i+2)
{
    sum=sum+array[i];
}
Console.WriteLine();
Console.WriteLine("Cумма элементов стоящих на нечетных позициях равна " + sum);
Console.WriteLine(); */

////////////////////////////////////////////////////////////////////////////////
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76 


/* Console.Clear();
int size = 5;

double[] array = new double[size];
double min = 30;
double[] array2 = new double[size];
double max = 0;

for (int i = 0; i < array.Length; i++)
{

    array[i] = new Random().NextDouble() * 30; // создать массив и в нем записать этот массив с усеченными элементами
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}    
{
    for (int i = 0; i < array.Length; i++)
    { 
        array2[i]=Math.Round(array[i], 3);
    }
}

Console.Write("Массив вещественных чисел:  ");
//Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", array2));
Console.WriteLine("Максимальный элемент массива: " + Math.Round(max, 3));
Console.WriteLine("Минимальный элемент массива: " + Math.Round(min, 3));
Console.WriteLine("Разница между максимальным и минимальным элементами массива равна " + Math.Round((max - min), 3)); */