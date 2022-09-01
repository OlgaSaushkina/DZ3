/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Clear(); 
Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int b = int.Parse(Console.ReadLine());

while (b<=0)
{
    Console.WriteLine("Число В должно быть больше 0");
    b = int.Parse(Console.ReadLine());
}
int pr=1;
for (int i=1; i<=b; i++)
{
    pr=(pr*a);
} 
Console.WriteLine("Число " + a + " в степени " + b + " равно " + pr);
Console.WriteLine();






// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/* /* 452 -> 11
82 -> 10
9012 -> 12 */

/* Console.Clear(); 
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i=0;
int sum=0;
while(n >0)
  {
    int a=n%10;
    n=n/10;
    i++;
    sum=sum+a;
  } 
  Console.WriteLine("Cумма цифр для указанного числа равна " + sum ); */

  //Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


/* Console.Clear(); 
void FillArray (int[] mas)
{   int length = mas.Length;
    int index = 0;
    while (index < length )
    {
    mas[index] = new Random().Next(0,100);
    index = index+1;
    }
}
void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
    Console.Write(col[position]+ ", ");
    position++;
    }
}
int[] array = new int[8]; 

FillArray(array);
PrintArray(array);
Console.WriteLine(); */



