// Домашнее задание.
// Добавить в код отладочный вывод, который позволит увидеть 
// "раскручивание" рекурсии, то есть процесс вовратов к местам 
// рекурсивного вызова функции на строке 9.
// Пример
// 5
// 4
// 3
// 2
// Stop reqursion:n=1
// Возврат:n=2, fact = 1
// Возврат:n=3, fact = 2
// Возврат:n=4, fact = 6
// Возврат:n=5, fact = 24
// 120

int Fact(int size)
{
    int result = 0;
    
    if(size == 0 || size == 1)
    {
        Console.WriteLine($"Stop requrson:n={size}");
        return 1;
    }
    Console.WriteLine(size);                                    //  Вызов рекурсий

    result = Fact(size - 1);
    Console.WriteLine($"Возврат:n={size}, fact={result}");      //  "Раскручивание рекурсии"
    result *= size;
    
    return result;
}

Console.Write(Fact(5)); 
