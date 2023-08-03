//Дан одномерный массив целых чисел, элементом которого, может быть либо 1, либо 0.
//Ваша задача вывести на экран максимальное количество следующих друг за другом 1.

Console.Write("Введите размер одномерного массива ");
int n = int.Parse(Console.ReadLine());
int[] array = Fill1dArray(n);
Print1dArray(array);
Console.WriteLine();
Console.WriteLine($"Количество максимально следующих друг за другом 1 равно: {GetMaxOneNumber(array)}");


int[] Fill1dArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}


void Print1dArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


int GetMaxOneNumber(int[] array)
{
    int n = 0;
    int m = n;
    for (int i = 0; i < array.Length; i++)
    {   
        if (array[i] == 1) n++;
        if (array[i] == 0 || i == array.Length-1)
        {
            if (n > m) m = n;
            n = 0;
        }
    }
    if (m==1) return 0;
    else return m;
}