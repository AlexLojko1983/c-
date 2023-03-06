/* Task: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */
/*
int Sum(int A)
{
    int sum = 0;
    for(int i = 1; i <= A; i++)
    {
        sum+=i;// sum = sum + i
    }
    return sum;
}

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Sum(number);
Console.WriteLine($"Сумма от 1 до {number} = {sum}");
*/
/*
Task2: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5      */
/*
Console.Write("Imput a first number: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 0;
while(num > 0)
{
    num = num / 10;
    count++;
}
Console.WriteLine($"Количество цифр равно: {count}");
/*
Task3: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120        */
/*
int Factorial(int num){
    int result = 1;
    for(int i = 1; i <= num; i++){
        result *= i;
    }
    return result;
}
Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Factorial (number);
Console.WriteLine(result);*/

/*
Task4: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]           */
/*
int[] FillArray(int size)
{
int[] arr = new int[size];
Random rnd = new Random();      //Класс создали
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0, 2);
}
return arr;
}

System.Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
 */


    
