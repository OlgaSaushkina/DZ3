//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/* 14212 -> нет
12821 -> да
23432 -> да */

Console.Clear(); 
Console.WriteLine("Введите пятизначное  число: ");
int num = int.Parse(Console.ReadLine());

while ((num<10000 || num>=100000) && (num<=-100000 || num>-10000) )
{
    Console.WriteLine("Введите пятизначное  число");
    num = int.Parse(Console.ReadLine());
}
int a=num/10000;
int e=num%10;
int b=(num/1000)%10;
int d=(num/10)%10;
if (num<0)
{
    Console.WriteLine("Отрицательное число не может являться палиндромом!");
}    
else if (a==e && b==d)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
} 



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


/* Console.Clear(); 
Console.WriteLine("Введите координаты двух точек: ");
Console.Write("x1 = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y1 = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("z1 = ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("x2 = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y2 = ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("z2 = ");
int z2 = int.Parse(Console.ReadLine());
//int d=Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
Console.WriteLine("Расстояние между двумя точками в 3D пространстве = " + Math.Sqrt(Math.Pow((x1-x2), 2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2))); */




//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/* Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
 Console.Write(a + " -> ");
a=Math.Abs(a);
for (int i=1; i<=a; i++)
{
    Console.Write(Math.Pow(i, 3) + ",");
   
}   */