/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными 
числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20. */


/*int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1);
        //Console.Write($"{res[i]} ");
    }
    return res;
} 

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length ; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}

void FindSum(int[] arr)
{
    int positiveSum = 0;
    int negativeSum = 0;

    foreach (int element in arr)
    {
        if (element > 0)
        {
            positiveSum += element;
        }
        else 
        {
            negativeSum += element;
        }
    }
Console.WriteLine();
Console.Write($"Sum positive num = {positiveSum}, Sum negative num = {negativeSum} ");
}
int[] array = GetArray(12, -9, 9);
PrintArray(array);
FindSum(array); */

/*
Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

/*
int[] GetArray (int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1, 5);
        //Console.Write($"{res[i]} ");
    }
    return res;
}


void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length ; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}

void FindSum(int[] arr) 
{                   // Вариант решения:
    int count = 0;  //bool flag = false;
    for (int el = 0; el < arr.Length; el++)
    {
        if (arr[el] == 4)
        {
            count++;  //flag = true;
        }
    }
    if (count > 0) //(flag)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }

}
int[] array = GetArray(5);
PrintArray(array);
Console.WriteLine();
FindSum(array); */


/* Задача 32: Напишите программу замена элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

/*
int[] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
        //Console.Write($"{res[i]} ");
    }
    return res;
}

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length ; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}

void ReNum(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}
int[] array = GetArray(4, -6, 6);
PrintArray(array);
ReNum(array);
Console.WriteLine();
PrintArray(array); */


/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */


/*int[] arr = {6, 7, 3, 6};

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int[] OpNum(int[] inArray)
{
    int[] count = new int [inArray.Length / 2];
    for (int i = 0; i < inArray.Length / 2; i++)
    {
         count[i] = inArray[i] * inArray[inArray.Length -1 -i];
    }
    return count;
} 
PrintArray(arr);
Console.WriteLine();
int[] res = OpNum(arr);
PrintArray(res); */

/* 
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество 
элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */


/* int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1, 123);
        //Console.Write($"{res[i]} ");
    }
    return res;
} 

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length ; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}

void FindNum(int[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length ; i++)
    {
        if (inArray[i] >= 10 && inArray[i] <= 99 )
        {
            count ++;
        }
    }
    Console.Write($"incoming elements - {count}");
}

int[] array = GetArray(5);
PrintArray(array);
Console.WriteLine();
FindNum(array); */





