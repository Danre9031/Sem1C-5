int size = Input("Введи размер: ");
int[] array = new int[size];
int result = 0;

FillArrayRandomNumbers(array);
PrintArray(array);

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        result += array[i];
    }
}

Console.Write($"Сумма чисел в массиве в нечетной позиции: {result}");

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