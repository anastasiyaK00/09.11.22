int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//array[0] = 12; // Каким образом можно обратиться к массиву и записать в него значение
//Console.WriteLine(array[0]); // Как обратиться к массиву и получить значение по указанному индексу

int result = Max(
Max(array[0], array[1], array[2]),
Max(array[3], array[4], array[5]),
Max(array[6], array[7], array[8])
);
Console.WriteLine(result);
/*
int max1 = Max(a1,b1,c1);
 int max2 = Max(a2,b2,c2);
 int max3 = Max(a3,b3,c3);
 int max = Max(max1, max2, max3);
 */