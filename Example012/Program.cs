// See https://aka.ms/new-console-template for more information
string metod4 (int count, string text)
{
    int i=0;
    string result = String.Empty;
while (i<count)
{
    result = result+text;
    i++;
}
return result;
}

string res = metod4(10,"z");
Console.WriteLine(res);