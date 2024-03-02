void ZeroEvenElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            array[i] = 0;
        }
    }
}

void FillArray(int[] array, int lowRangeBorder, int highRangeBorder)
{
    Random rnd = new();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(lowRangeBorder, highRangeBorder);
    }
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

void GetSumOfElements(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        sum += item;
    }
    Console.Write($"Сумма элементов массива = {sum}\n");
}

void GetProductOfElements(int[] array)
{
    int multiplicator = 1;
    foreach (int item in array)
    {
        multiplicator *= item;
    }
    Console.Write($"Произведение элементов массива = {multiplicator}\n");
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];

FillArray(array, 1, 5);
PrintArray(array);
GetSumOfElements(array);
GetProductOfElements(array);
ZeroEvenElements(array);
PrintArray(array);