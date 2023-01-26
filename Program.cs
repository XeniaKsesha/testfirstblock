void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SortArray(string[] array1, string[] sortedarray)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        sortedarray[count] = array1[i];
        count++;
        }
    }
}

string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] sortedarray = new string[array1.Length];

SortArray(array1, sortedarray);
PrintArray(sortedarray);