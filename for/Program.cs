//string Method4(int count, string text)
/*{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
{
    result = result + text;
}
return result;
}
string res = Method4(3, "asdf");
//Console.WriteLine(res);

// Вложенные цыклы на примере таблицы умножения
for(int i=2; i <=10; i++)
{
    for(int j=2; j<=10; j++)
    {
    //    Console.WriteLine($"{i}x{j}={i*j}");
    }
//Console.WriteLine();
}*/


// Обработка текста
// Пробелы заменить на | маленькие "к" на большие "К" большие "С" на маленькие "с"

string text = "Я думаю Саша клякса князь"
            +"кот Суп Скрипка";
// string s ="qwerty"
//            0123
// s[3] r

string Replace(string text, char old1, char new1)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i=0; i<length; i++)
    {
        if(text[i] == old1)      
            result = result +$"{new1}";
        
        else 
              
            result = result + text[i];
            
    }  
            
            
    
            return result;
}  

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
 newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);

