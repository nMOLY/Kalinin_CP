//Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. Определите, является ли ваша строка допустимой.
//Исходная строка считается допустимой при условии:
//1. Открытые скобки должны быть закрыты скобками того же типа.
//2. Открытые скобки должны быть закрыты в правильном порядке.
//4. Каждая закрывающия скобка имеет соответствующую открытыю скобку того же типа.


string s = "{[()]}";
Console.WriteLine(getIt(s));

bool getIt(string s)
{
    var dictionary = new Dictionary<char, int>()
    {
        { '(', 1 },
        { ')', 10 },
        { '[', 2 },
        { ']', 20 },
        { '{', 3 },
        { '}', 30 },
    };
    if (s.Length % 2 == 1) return false;
    Stack<char> sStack = new Stack<char>();
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(' || s[i] == '{' || s[i] == '[')
        {
            sStack.Push(s[i]);
        }
        if (s[i] == ')' || s[i] == '}' || s[i] == ']')
        {
            if (sStack.Count == 0) return false;
            if (dictionary[sStack.Peek()] * 10 == dictionary[s[i]])
            {
                sStack.Pop();
            }
            else return false;
        }
    }
    if (sStack.Count == 0) return true;
    else return false;
}

