int minElement = ReadInt("Введите минимальное число диапазона: ");
int maxElement = ReadInt("Введите максимальное число диапазона: ");
int[] numbers = new int[maxElement - minElement + 1];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = minElement + i;
}

WriteIntArray(numbers);
Console.WriteLine();
Suffle(numbers);
WriteIntArray(numbers);

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void Suffle(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int j = new Random().Next(0, array.Length);
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
