int arrSize = Convert.ToInt32(Console.ReadLine());
string [] arr = new string [arrSize];

    for (int i = 0; i < arrSize; i++)
    {
        arr [i] = Console.ReadLine();
    }
Console.Write($"[{String.Join("; ", arr)}]");

Console.Write(" ---> [");
for (int j = 0; j < arrSize; j++)
{
    if (arr[j].Length <= 3 )
    {
    Console.Write(arr[j] + " ;");
    }

}
Console.Write("]");

