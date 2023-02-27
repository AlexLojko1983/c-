// Task: find max array
/*
int Max(int arg1,int arg2,int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int[] array = {1,2,21,33,3337,35,46,48,59};                                

array[0] = 12;
// Console.WriteLine(array[0]);
 
int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);
*/
// Task: find position
/*
int[] array = {1,46,21,33,37,35,46,48,59};

int n =array.Length;
int find = 46;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine("index = " + index);
    }
    index++;
}
*/

// Task: find first position
/*
int[] array = {1,46,21,33,37,35,46,48,59};

int n =array.Length;
int find = 46;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine("index = " + index);
        break;
    }
    index++;
}
*/
// Task find max random array

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int pozition = 0;
    while (pozition < count)
    {
        Console.Write(col[pozition] + " ");
        pozition++;
    }
}

int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int pozition =-1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            pozition = index;
            break;
        }
        index++;
    }
    return pozition;
}

int[] array = new int[100];      //Sozdaem array s indexom 9 array[i]=0 (pystoj)
FillArray(array);
PrintArray(array);
Console.WriteLine();
int d = IndexOf(array, 5);
Console.WriteLine(d);