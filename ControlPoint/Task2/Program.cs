//Дан одномерный массив целых однозначных чисел (элемент массива содержит число от 1 до 9).
//Ваша задача вывести на экран число, которое формируется элементами массива слева-направо + 1.

Console.Write("Введите размер одномерного массива ");
int n = int.Parse(Console.ReadLine());
int[] array = Fill1dArray(n);
Print1dArray(array);
Console.WriteLine();
Console.WriteLine($"Искомое число: {GetNumberPlusOne(array)}");


int[] Fill1dArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
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

int GetNumberPlusOne(int[] array)
{
    int number = 0;
    int degree = 1;
    for (int i = array.Length-1; i >= 0; i--)
    {
        number += array[i]*degree;
        degree *= 10;
    }
    return number+1;
}