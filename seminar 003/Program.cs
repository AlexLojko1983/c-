/*Task1: Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/
/*
Console.Write("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
{
    Console.WriteLine("1 четверть");
}
else if (x<0 && y>0)
{
    Console.WriteLine("2 четверть");
}
else if (x<0 && y<0)
{
    Console.WriteLine("3 четверть");
}
else if (x>0 && y<0)
{
    Console.WriteLine("4 четверть");
}
else 
     Console.WriteLine("На оси");
     */
/*Task2: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат
 точек в этой четверти (x и y).
     */
     /*
Console.Write("Введите четверть: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num ==1)
{
    Console.WriteLine("x>0 y>0");
}
else if (num ==2)
{
    Console.WriteLine("x<0 y>0");
}
else if (num ==3)
{
    Console.WriteLine("x<0 y<0");
}
else if (num ==4)
{
    Console.WriteLine("x>0 y<0");
}
else 
     Console.WriteLine("Не четверть");*/
/*Task3 : Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
 между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/ 
/*
Console.Write("Введите координату Х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());    

double kat1 = (x1-x2);
double kat2 = (y1-y2);
double gip = Math.Sqrt(Math.Pow(kat1, 2)  + Math.Pow(kat2, 2));
Console.WriteLine(gip);
// double res = Math.Pow(number, 2); // возведение в степень
// double res = Math.Sqrt(number); // извлечение квадратного корня
// res = Math.Round(res, 3); // округление
*/
/* Task4: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;
// int[] L = new int[100]; 
while(current <= num)
{
    // L.Append[Math.Pow(current, 2)];
    Console.WriteLine(Math.Pow(current, 2));
    // Console.WriteLine(L);
    current ++;
}
*/