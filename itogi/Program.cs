int arrSize = Convert.ToInt32(Console.ReadLine());
string [] arr = new string [arrSize];

    for (int i = 0; i < arrSize; i++)
    {
        arr [i] = Console.ReadLine();
    }
Console.Write($"[{String.Join("; ", arr)}]");



