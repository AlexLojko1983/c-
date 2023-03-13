/* Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет 
на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

/*
int[] FillArrayWhithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

void ReverseArray(int[] arr)
{
    int temp = 0;

    for(int i = 0; i < arr.Length/2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
ReverseArray(array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
*/


/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли 
существовать треугольник со сторонами такой длины.Теорема о неравенстве треугольника: 
каждая сторона треугольника меньше суммы двух других сторон.*/
/*
void Triangle(int x, int y, int z)
{
    if (x + y > z && x + z > y && y + z > x)
        System.Console.Write($"Треугольник со сторонами a = {x}, b = {y}, c = {z} существует!");
    else
        System.Console.Write($"Треугольника со сторонами a = {x}, b = {y}, c = {z} не существует!");
}

System.Console.Write("Введите первую сторону треугольника a = : ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите первую сторону треугольника b = : ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите первую сторону треугольника c = : ");
int c = Convert.ToInt32(Console.ReadLine());

Triangle(a,b,c);    */

/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10    */

void ConvertToBinary(int num)
{
    int[] bin = Array.Empty<int>();
    while(num != 0)
    {
        bin = bin.Append(num%2).ToArray();
        num/=2;
    }
    bin.Reverse();
    Console.WriteLine(string.Join(" ", bin));
}


System.Console.Write("Введите число n = : ");
int n = Convert.ToInt32(Console.ReadLine());

ConvertToBinary(n);

/*

void PrintBinary(int number)
{
if(number <= 0)
{
return;
}

PrintBinary(number/2);
Console.Write(number%2);
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintBinary(number);
*/

/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8     */

/*
Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
array[0] = 0;
array[1] = 1;
for(int i = 2; i <  number; i++){
    array[i] = array[i-2] + array[i-1]; 
}
Console.Write("Array: ");
Console.WriteLine($"[{string.Join(", ", array)}]");
*/
void PrintFibToN(int N)
// {
//     int fib1 = 0;
//     int fib2 = 1;
//     int fib3 = 0;
//     Console.Write("0 1 ");
//     for(int i = 0; i < N - 2; i++)
//     {
//         fib3 = fib1 + fib2;
//         Console.Write($"{fib3} ");
//         fib1 = fib2;
//         fib2 = fib3;
//     }
// }


// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// PrintFibToN(number);

/* Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью 
поэлементного копирования.  */

int [] FillArrayWithRandomNumbers(int size){
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i=0; i<arr.Length;i++){
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

Console.Write("Input array size "); 
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(size);
Console.Write("Array: ");
Console.WriteLine($"[{string.Join(", ", array)}]");
int[] newArray = new int[array.Length];
for(int i =0; i<array.Length; i++){
    newArray[i] = array[i];
}
Console.Write("New array: ");
Console.WriteLine($"[{string.Join(", ", newArray)}]");