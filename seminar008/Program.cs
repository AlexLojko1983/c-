/*Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.*/
/*
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rnd.Next(-10, 20);
        }
    }
    return array;
}
void ChangeMatrix(int[,] matrix)
{
   int num =0;
   int ii = matrix.GetLength(0)-1;
   //for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {                
            num = matrix[0,j];
            matrix[0,j] = matrix[ii,j];
            matrix[ii,j]= num;             
        }
               
    } 
}
int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}
int n = Number("Input row number: ");
int m = Number("Input colum number: ");
int[,] matrix = FillMatrixWithRandom(n,m);
PrintMatrix(matrix);
System.Console.WriteLine();
ChangeMatrix(matrix);
PrintMatrix(matrix);
*/

/*Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.*/
/*
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rnd.Next(-10, 20);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}
int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[,] ChangeRowColumMatrix(int[,] matrix)
{
   int [,] newarr = new int[matrix.GetLength(1), matrix.GetLength(0)];
  
   for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {                
            newarr[j,i] = matrix[i,j];                        
        }               
    } 
    return newarr;
}
int n = Number("Input row number: ");
int m = Number("Input colum number: ");
int[,] matrix = FillMatrixWithRandom(n,m);
PrintMatrix(matrix);
System.Console.WriteLine();
int [,] newarr = ChangeRowColumMatrix(matrix);
PrintMatrix(newarr);
*/
/* Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза*/
/*
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void FindMatrix(int[,] matrix)
{
   int countel = 0;
   for (int l = 0; l < 10; l++ )
   {  
        for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {                
                    if (l==matrix[i,j])
                    {
                        countel += 1;
                    } 
                    // System.Console.WriteLine($"{l} встречается {countel} раза");                       
                }
                // System.Console.WriteLine($"{l} встречается {countel} раза");            
            }
            System.Console.WriteLine($"{l} встречается {countel} раза");
            countel = 0;
   }             
    
}

int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int n = Number("Input row number: ");
int m = Number("Input colum number: ");
int[,] matrix = FillMatrixWithRandom(n,m);
PrintMatrix(matrix);
FindMatrix(matrix);   
*/
/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7 */

int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int FindMinMatrix(int[,] matrix)
{
    int min = matrix[0, 0];
    int k = 0;
    int l = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                k = i;
                l = j;
            }
        }
    }
    return k;
}
int FindMinMatrix1(int[,] matrix)
{
    int min = matrix[0, 0];
    int k = 0;
    int l = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                k = i;
                l = j;
            }
        }
    }
    return l;
}

int[,] FindMatrix(int[,] matrix, int k, int l)
{
    int[,] newarr = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == k || j == l)
            {
                i++;
                break;
            }
            if (j == l)
            {
                j++;
                break;
            }
            else
            {
                for (int m = 0; m < newarr.GetLength(0); m++)
                {
                    for (int n = 0; n < newarr.GetLength(1); n++)
                    {
                        newarr[m, n] = matrix[i, j];
                    }
                }
            }
        }
    }
    return newarr;
}


int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int n = Number("Input row number: ");
int m = Number("Input colum number: ");
int[,] matrix = FillMatrixWithRandom(n, m);
PrintMatrix(matrix);
System.Console.WriteLine();
int k = FindMinMatrix(matrix);
System.Console.WriteLine(k);
int l = FindMinMatrix1(matrix);
System.Console.WriteLine(l);
int[,] newarr = FindMatrix(matrix, k, l);
PrintMatrix(newarr);
