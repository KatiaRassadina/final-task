// See 
int size = 8;
string[] arrayFirst = new string[size];
Console.WriteLine($"Input {size} elemets of massive");
FillArray(arrayFirst);
PrintArray(arrayFirst);
void FillArray (string[] arr)
{
    for(int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine() ?? " ";
    }
}
void PrintArray(string[] arr)
{
    Console.Write("[");
    for(int i = 0; i < size; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}