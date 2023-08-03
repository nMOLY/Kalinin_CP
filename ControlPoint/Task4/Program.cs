//Даны два положительных целых числа, представленных в виде строк. Необходимо получить сумму чисел, 
//которые представлены этими строками. Причем полученная сумма должна быть преобразована в строку.
/*
Пример 1:
Входные значения: num1 = "11", num2 = "123"
Результат: "134"

Пример 2:
Входные значения: num1="456", num2 = "77"
Результат: "533"

Пример 3:
Входные значения: num1 = "0", num2 = "0"
Результат: "0"
*/

Console.WriteLine("Введите первое число: ");
string num1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string num2 = Console.ReadLine();
Console.WriteLine("Ваша сумма равна: ");
string summa = SumOfString(num1, num2);
Console.WriteLine(summa);

string SumOfString(string num11, string num22)
{

    var num1 = new Dictionary<int, string>();
    var num2 = new Dictionary<int, string>();
    var sum = new Dictionary<int, string>();
    num1.Add(-1, "0");
    if (num11.Length > num22.Length)
    {
        for (int i = 0; i < num11.Length; i++)
        {
            num1.Add(i, num11[i].ToString());
        }
        for (int i = 0; i < num22.Length; i++)
        {
            num2.Add(i, num22[i].ToString());
        }
    }
    else
    {
        for (int i = 0; i < num22.Length; i++)
        {
            num1.Add(i, num22[i].ToString());
        }
        for (int i = 0; i < num11.Length; i++)
        {
            num2.Add(i, num11[i].ToString());
        }
    }
    for (int i = num2.Count - 1, j = num1.Count - 2; i >= 0; i--, j--)
    {
        if (Int32.Parse(num1[i]) > 9)
        {
            num1[j] = ((Int32.Parse(num1[j]) + Int32.Parse(num2[i])) % 10).ToString();
            num1[j - 1] = (Int32.Parse(num1[j - 1]) + 1).ToString();
        }
        else num1[j] = (Int32.Parse(num2[i]) + Int32.Parse(num1[j])).ToString();
    }
    for (int i = num1.Count - 2; i >= 0; i--)
    {
        if (Int32.Parse(num1[i]) > 9)
        {
            num1[i] = (Int32.Parse(num1[i]) % 10).ToString();
            num1[i - 1] = (Int32.Parse(num1[i - 1]) + 1).ToString();
        }
    }
    int checkForZero;
    if (Int32.Parse(num1[-1]) == 0)
    {
        num1.Remove(-1);
        checkForZero = 0;
    }
    else checkForZero = 1;
    char[] sum1 = new char[num1.Count];
    for (int i = 0; i < sum1.Length; i++)
    {
        sum1[i] = char.Parse(num1[i - checkForZero]);
    }
    return new string(sum1);
}