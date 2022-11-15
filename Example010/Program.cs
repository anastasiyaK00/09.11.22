﻿/*
.......Условия: 
Имеется одномерный массив array из n элементов, 
требуется найти элемент массива равный find.
.......Алгоритм:
1) Установить счетчик index в позицию 0
2) Если array [index] = find, алгоритм завершил работу успешно.
3) Увеличить idex на 1
4) Если index<n, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.
*/

int [] array = {1,24,32,44,55,66,77,83};
int n = array.Length; //возвращает длину/ количество элементов массива
int find = 66; //число, которое мы будем искать 

int index = 0;

while (index< n)
{
    if(array[index]==find) //Если тот элемент, который находится по нужному индексу совпадает, т.е равен find
    {
        Console.WriteLine(index);
        break; // *заканчиваем. Нужна в т.сл. если несколько одинаковых чисел в массиве, тогда он останавливает д-ия на первом попавшемся..Удобненько-_-
    }
index=index+1; // index++
}