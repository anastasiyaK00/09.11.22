//таблица умноэения цикл фор в цикле фор
 
 for ( int i=2; i<=10; i++)
 {
    for (int j = 0; j<=10; j++)
    {
        int p = i*j;
        Console.WriteLine($"{i}X{j}={p}");
    }
    Console.WriteLine(" ");
 }