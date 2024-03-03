int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }

    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");   // Интерполяция строк
        }

        Console.WriteLine();
    }
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;
    }

    return sum;
}

bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    return (sumOfDigits % 2 == 0 ? true : false);
}

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);

foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}