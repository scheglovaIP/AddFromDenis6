int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
FillIntArray(numbers, 0, 10);
WriteIntArray(numbers);

int addNumber = ReadInt("Введите число, которое необходимо добавить в массив: ");
numbers = AddToArray(numbers, addNumber);
WriteIntArray(numbers);

int indexDel = ReadInt("Введите порядковый номер числа, которое необходимо удалить: ");
numbers=RemoveFromArray(numbers, indexDel);
WriteIntArray(numbers);



int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillIntArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void WriteIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void CopyElementsArray(int[] arrayIn, int[] arrayOut)
{
    for (int i = 0; i < arrayIn.Length; i++)
    {
        arrayOut[i] = arrayIn[i];
    }
}

int[] AddToArray(int[] elements, int newElement)
{
    int length = elements.Length;
    int[] tempArray = new int[length + 1];
    CopyElementsArray(elements, tempArray);
    tempArray[elements.Length] = newElement;
    return tempArray;
}

int[] RemoveFromArray(int[] elements, int index)
{
    int[] tempElements = new int[elements.Length - 1];
    for (int i = 0; i < elements.Length - 1; i++)
    {
        if (i >= index - 1)
            tempElements[i] = elements[i + 1];
        else tempElements[i] = elements[i];
    }

    return tempElements;
}