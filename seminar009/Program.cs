// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
/*
void PrintNumberToN(int N)
{
if (N == 0)
{
return;
}
PrintNumberToN(N-1);
System.Console.Write($"{N} ");
}
System.Console.Write("Введите число N: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
PrintNumberToN(firstNumber);
*/
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
/*
void PrintNumberToN(int N, int M)
{
if (N == M-1)
{
return;
}
PrintNumberToN(N - 1, M);
System.Console.Write($"{N} ");
}
System.Console.Write("Введите число N: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число М: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
PrintNumberToN(firstNumber, secondNumber);
*/
/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/
/*
int SumNumber(int N)
    {
    if (N == 0)
    {
    return 0;
    }
    return N%10 + SumNumber(N/10);
}
System.Console.Write("Введите число N: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumNumber(firstNumber));
*/

/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
int MultNumber(int N, int M)
{
    if (M == 0)
    {
        return 1;
    }
    return N*MultNumber(N,M-1);
}
System.Console.Write("Введите число N: ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число М: ");
int pow = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(MultNumber(Number, pow));
