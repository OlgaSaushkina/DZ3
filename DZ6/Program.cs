//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/* Console.Clear();
Console.WriteLine("Введите число (указывающее сколько чисел Вы хотите ввести): ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine();
int count=0;
Console.WriteLine("Введите числa: ");
for (int i = 0; i < a; ++i)
{   
    int n= int.Parse(Console.ReadLine()); 
    if (n> 0)
    {
        count=count+1;
    }
}
Console.WriteLine();
Console.WriteLine("Количество чисел больших 0  равно   " + count);  */

////////////////////////////////////////////////

//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Для того чтобы найти точку пересечения двух прямых, введите значения: ");
Console.WriteLine();
Console.WriteLine("Введите значения: ");
Console.Write("b1 = ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("k1 = ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("b2 = ");
double b2 = int.Parse(Console.ReadLine());
Console.Write("k2 = ");
double k2 = int.Parse(Console.ReadLine());
Console.WriteLine();
if (k2 == k1 && b1==b2) {
    Console.WriteLine("Если  k1 = k2 и b1=b2 -> прямые совпадают");
}
else if(k2 == k1 && b1!= b2)
{
    Console.WriteLine("Если  k1 = k2 -> прямые параллельны");
}
else{
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine("Точка пересечения двух прямых -> " + (x, y));
}
Console.WriteLine();