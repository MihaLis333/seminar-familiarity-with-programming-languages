/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт
сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

/*
int GetSumNums(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number;
        number--;
    }
    return sum;
}

Console.Write("Input number: ");
int num = int.Parse(Console.ReadLine());

Console.Write("Input number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Input number: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"sum of all numbers = {GetSumNums(num)}");
Console.WriteLine($"sum of all numbers = {GetSumNums(num1)}");
Console.WriteLine($"sum of all numbers = {GetSumNums(num2)}"); */

/*
Задача 26: Напишите программу, которая принимает на вход число и 
выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

/*
int NumberOfDigits(int number)
{
    int count = 0;
    int digits = number;
    while (digits > 0)
    {
        digits = digits / 10;
        count++;
    }
    return count;
}

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Numbers of digits = {NumberOfDigits(number)}"); */

/*
Задача 28: Напишите программу, которая принимает на вход число N и 
выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120 */

/* int ProductOfNumbers(int number)
{
    int sum = 1;
    for (int i = 1; number >= i; i++)
    {
        sum = sum * i;
    }
    return sum;
}

Console.Write("Input number: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"sum of all numbers = {ProductOfNumbers(num)}"); */


/* 
Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */
   
/* void FillArray(int[] array)      // Вариант сборки ребят на семинаре
{
int length = array.Length;

for (int index = 0; index < length; index++)
{
array[index] = new Random().Next(0, 2);
Console.Write(array[index] + " ");
}
}

void PrintArray(int[] mas)
{
int len = mas.Length;
for (int i = 0; i < len; i++)
{
Console.Write(mas[i] + " ");
}
}

int[] arr = new int[8];
FillArray(arr);
Console.WriteLine();
PrintArray(arr); */





