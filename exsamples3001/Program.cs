/*
for (int i=2; i<=10; i++)
{
    for(int j = 2; j<=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine("");
}
*/
// Task1 :  дан текст. Заменить пробелы черточками, маленькие "к" заменить "К", большие "С" маленькими "с"
/*
string text = "рфаыраиСмофрлщащф фдывларвыш длрфмфдвыкк ССС";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;   // Пустая строка
    int length = text.Length;
    for(int i =0; i<length; i++)
    {
        if(text[i] == oldValue) result += $"{newValue}";    //Можно так добавлять в пустую строку
        
        else result += text[i];                             // А можно так
        
    }

    return result;
}
string newtext = Replace(text, ' ', '|');
Console.WriteLine(newtext);
Console.WriteLine();
string newtext1 = Replace(newtext, 'к','К');
Console.WriteLine(newtext1);
Console.WriteLine();
string newtext2 = Replace(newtext1, 'С','с');
Console.WriteLine(newtext2);
*/
// Task2: Сортировка
/*
int[] arr = {1,2,3,7,9,5,1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i=0;i<count;i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i=0; i<array.Length-1; i++)
    {
        int minPosicion = i;

        for(int j=i+1;j<array.Length;j++)
        {
            if(array[j]<array[minPosicion]) minPosicion = j;
        }
        int tempory = array[i];
        array[i] = array[minPosicion];
        array[minPosicion] = tempory;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/