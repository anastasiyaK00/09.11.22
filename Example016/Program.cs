// сортировка массива

int[] arr = { 7, 4, 3, 5, 2, 9, 23, 6 };

void PrintArray(int[] array) //Метод, печатающий наш массив
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine(" ");
}

void Selection(int[] array)
{
    for (int i = 0; i < array.Length -1 ; i++)
    {
        int minposition = i; // та позиция на которую смотрим

        for (int j = i + 1; j < array.Length; j++)//+1 тк с не отсортированного начинаем
        {
            if (array[j] > array[minposition])
            {
                minposition = j;
            }
        }

        int temporary = array[i];// меняем позицию минимального с той, которую нашли 
        array[i] = array[minposition];//обмен двух переменных местами
        arr[minposition] = temporary; //кладем в мин тот что временный
    }
}


PrintArray(arr);
Selection(arr);
PrintArray(arr);