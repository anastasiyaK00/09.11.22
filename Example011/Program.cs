void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // void-это метод, кот. ничего не возвращает 
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Так мы сможем вывести число, которого нет в массиве. Т.е. если например число будет 444 то выведется -1
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //Определили массив из 10 эллементов

FillArray(array); // Заполнил массив
array[4]=4;
array[6]=4;

PrintArray(array); //Распечатал массив
Console.WriteLine();

int pos = IndexOf(array, 443);
Console.WriteLine(pos);