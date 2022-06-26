int size = Input("Введи размер: ");
int[] array = new int[size];

FillArrayRandomNumbers(array);
PrintArray(array);
Console.WriteLine(SumMaxAMinNumbers(array));

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
}

void PrintArray(int[] arr)
{
    int size = arr.Length;
    Console.Write($"[");
    for (int i = 0; i < size - 1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write($"{arr[size - 1]}]");
    Console.WriteLine();
}

int SumMaxAMinNumbers(int[] array)
{
    int result = 0;
    int temp = 1;
    int max = int.MinValue;
    int min = int.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        temp = array[i];
        if (temp > max)
        {
            max = temp;
        }
        else if (temp < min)
        {
            min = temp;
        }

    }
    result = max - min;
    return result;

}