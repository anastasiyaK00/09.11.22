// Внести изменения в текст
Console.Write("add text:");
string text = Console.ReadLine();

string Replace ( string text, char Old, char New)
{
    string result = string.Empty;
    int Length = text.Length;
    for (int i = 0; i<Length; i++)
    {
        if (text[i] == Old) 
        {
            result=result+ New;
        }
        else 
        {
           result= result + text[i];
        }
    }
    return result;
}


string newText = Replace(text,' ', '|');
Console.WriteLine(" ");
string newText1 = Replace(text,'k', 'K');
Console.WriteLine(" ");
string newText2 = Replace(text,'o', 'O');
Console.WriteLine(" ");
Console.WriteLine(newText2);
