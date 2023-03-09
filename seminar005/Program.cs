// Task1: // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.
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

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);

int sumPositive = 0;
int sumNegative = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        sumPositive+= array[i];
    }
    else
    {
        sumNegative+= array[i];
    }
}

System.Console.Write("Ваш случайный массив: ");
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"Сумма положительных значений равна {sumPositive}, а сумма отрицательных значений равна {sumNegative}");
*/

// Task2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в 
// массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
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


void Find (int[] arr, int n)
{
    int count = 0;
    for(int i=0; i < arr.Length; i++)
    {
        
        if (n == arr[i])
        {
            Console.WriteLine("Yes");
            
            break;
        }
        else
        {
            count += 1;
        } 
    } 
    if(count == arr.Length)
        Console.WriteLine("No");   
}
System.Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr1 = FillArrayWhithRandomNumber(size);
System.Console.WriteLine($"[{string.Join(", ", arr1)}]");
Find(arr1,n);
*/
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

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine("Введите число: ");
int search = Convert.ToInt32(Console.ReadLine());

bool isOk = false;
for(int i = 0; i < array.Length; i++)
{
if(search == array[i])
{
isOk = true;
break;
}
}
if(isOk)
{
System.Console.WriteLine("Элемент найден");
}
else
{
System.Console.WriteLine("Элемент не найден");
}

// Второй вариант решения
string result = "No";

for(int i=0; i<array.Length; i++){
if(array[i] == search){
result = "yes";
break;
}
}
System.Console.WriteLine(result);
*/
// Task3:  Напишите программу замена элементов массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
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

int[] ChangeArray(int[] arr, int size)
{
// Чтобы работать с массивом используем копирования массива в отдельный, чтобы не было изменение изначального
int[] copyArr = new int[size];
// for(int i = 0; i < copyArr.Length; i++)
// {
// copyArr[i] = arr[i];
// }
arr.CopyTo(copyArr,0);

for(int i = 0; i < copyArr.Length; i++)
{
    copyArr[i] *= -1;
}
return copyArr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);

int[] changeArray = ChangeArray(array, size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"[{string.Join(", ", changeArray)}]");
*/

// // Task4: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
/*
int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0, 150);
}
return arr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
int count = 0;
for(int i = 0; i < array.Length; i++)
{
if(array[i] >= 10 && array[i] <= 99)
{
count++;
}
}
System.Console.WriteLine(count);
*/
// Task5: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr1 = FillArrayWhithRandomNumber(size);
System.Console.WriteLine($"[{string.Join(", ", arr1)}]");


int [] arrResult = Array.Empty<int>();      //создали пустой массив

// System.Console.WriteLine($"[{string.Join(", ", arrResult)}]");

for (int i=0; i < arr1.Length/2; i++)     
    arrResult = arrResult.Append(arr1[i] * arr1[arr1.Length-1-i]).ToArray();        //добавляем элементы в массив
if(arr1.Length % 2 > 0)
    arrResult = arrResult.Append(arr1[arr1.Length/2]).ToArray();    

System.Console.WriteLine($"[{string.Join(", ", arrResult)}]");
