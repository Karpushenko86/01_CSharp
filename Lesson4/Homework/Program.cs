static string GetDigitsFromString(string? s)
{
    string str = "";
    if (s == null)
    {
        return str;
    } 
    else
    {
        foreach (char e in s)
        {
            if (char.IsAsciiDigit(e) == true)
            {
                str += e;
            }
        }
    }

    return str;
}

static int[] GetArrayFromString(string s)
{
    int[] array = new int [s.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[array.Length - i - 1] = Convert.ToInt32(s) % 10;
        s = Convert.ToString(Convert.ToInt32(s) / 10);
    }
    
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]\n");
}

Console.Write("Введите строку состоящую из цифр и латинских букв (не больше 10 цифр в строке): ");
string? input = Console.ReadLine();
Console.Write($"{input} => ");
input = GetDigitsFromString(input);
int[] array = GetArrayFromString(input);
PrintArray(array);

