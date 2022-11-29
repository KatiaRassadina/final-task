// See 
int size = 8;
int n = 3;
string[] arrayFirst = new string[size];
Console.WriteLine($"Input {size} elemets of massive");
FillArray(arrayFirst);
PrintArray(arrayFirst);
Console.WriteLine($"New massive with elements <= {n}:");
Console.WriteLine();
if (FindSizeSecondArray(arrayFirst) == 0)
{
    Console.WriteLine("Nothing suitable for new massive");
}
else
{
    string[] arraySecond = TransferElements(arrayFirst);
    PrintArray(arraySecond);
}
void FillArray (string[] arr)
{
    for(int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine();
    }
}
void PrintArray(string[] arr)
{
    int k = arr.Length;
    Console.Write("[");
    for(int i = 0; i < k; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}
int FindSizeSecondArray(string[] arr)
{
    int SecondSize = 0;
    for(int i = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
       {
            SecondSize++;
       }   
    }
    return SecondSize;
}
string[] TransferElements(string[] arr)
{
    string[] arraySecond = new string[FindSizeSecondArray(arrayFirst)];
       for(int i = 0, j = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
       {
            arraySecond[j] = arr[i];
            j++;
       }   
    }
return arraySecond;
}