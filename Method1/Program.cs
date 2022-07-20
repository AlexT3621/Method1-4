//1. Ничего не принимают, и ничего не возвращают

/*void Method1()
{
    Console.WriteLine("Автор Саша");
}

Method1();*/
//2. могут принимать аргумент, но ничего не выводят

/*void Method2(string msg)
    {
        Console.WriteLine(msg);
    }
Method2("Текст сообщения");*/

// Могут быть именовыванные аргументы
void Method21(string msg, int count)
    {
        int i = 1;
        while(i < count)
        {
        Console.WriteLine(msg);
        i++;
        }

    }
//Method21(msg: "Текст сообщения", count: 4); // необязательно писать по порядку можно и так ethod21(count: 4, msg: "Текст сообщения");

// 3. Ничего не принимают, но возвращают.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// 4. Что-то принимают и что-то возвращают.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);


