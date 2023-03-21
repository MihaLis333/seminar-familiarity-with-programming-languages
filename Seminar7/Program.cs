/*
Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1 
*/

/*int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i =0; i < m; i++)
    {
        for(int j =0; j < n; j++)
        {
            result[i, j] = new Random(). Next(minValue, maxValue);
            //Console.Write($"{result[i, j]} ");
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i =0; i < inArray.GetLength(0); i++) //- GetLength(0) обращение к длинне двумерного массива, 0 это обарщение к строкам
    {
        for(int j =0; j < inArray.GetLength(1); j++) //- GetLength(1) обращение к длинне двумерного массива, 1 это обарщение к столбцам
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }

}


Console.Write("Enter the number of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Enter the number of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array); */

/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

/*int[,] GetArray(int m, int n) //int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i =0; i < m; i++)
    {
        for(int j =0; j < n; j++)
        {
            result[i, j] = new Random(). Next(0, 10);
            //Console.Write($"{result[i, j]} ");
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i =0; i < inArray.GetLength(0); i++) //- GetLength(0) обращение к длинне двумерного массива, 0 это обарщение к строкам
    {
        for(int j =0; j < inArray.GetLength(1); j++) //- GetLength(1) обращение к длинне двумерного массива, 1 это обарщение к столбцам
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }

}

void SumArray(int[,] sArray)
{
    for(int i =0; i < sArray.GetLength(0); i++) 
    {
        for(int j =0; j < sArray.GetLength(1); j++) 
        {
            sArray[i,j] = i +j;
            Console.Write($"{sArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


Console.Write("Enter the number of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Enter the number of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array); 
Console.WriteLine();
SumArray(array); */


/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
*/


/*int[,] GetArray(int m, int n) //int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i =0; i < m; i++)
    {
        for(int j =0; j < n; j++)
        {
            result[i, j] = new Random(). Next(1, 10);
            //Console.Write($"{result[i, j]} ");
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i =0; i < inArray.GetLength(0); i++) 
    {
        for(int j =0; j < inArray.GetLength(1); j++) 
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }

}

void SerchIndex(int[,] sArray)
{
    for(int i =0; i < sArray.GetLength(0); i++) 
    {
        for(int j =0; j < sArray.GetLength(1); j++) 
        {
            if(i %2 ==0 && j %2 ==0)
            {
                sArray[i, j]= Convert.ToInt32(Math.Pow(sArray[i, j], 2));
            }
        }
    }

}


Console.Write("Enter the number of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Enter the number of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array); 
Console.WriteLine();
SerchIndex(array); 
PrintArray(array); */

/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

int[,] GetArray(int r, int c)
{
    int[,] result = new int[r, c];
    for(int i =0; i < r; i++)
    {
        for(int j =0; j <c; j++)
        {
            result[i, j] = new Random().Next(1, 10);
            //Console.Write($"{result[i, j]} ");
        }
        //Console.WriteLine();
    }
    return result;
}

void PrintArray(int[,] pArray)
{
    for(int i =0; i < pArray.GetLength(0); i++)
    {
        for( int j =0; j < pArray.GetLength(1); j++)
        {
            Console.Write($"{pArray[i, j]} ");
        }
        Console.WriteLine();
    }
    
} 

int SumElemDiag(int[,] sArray)
{
    int sum =0;
    for(int i =0; i < sArray.GetLength(0); i++) 
    {
        for(int j =0; j < sArray.GetLength(1); j++) 
        {
            if(i==j)
            {
                sum = sum + sArray[i, j];
            }
        }
    }
    return sum;

}


int[,] array = GetArray(5, 6);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"{SumElemDiag(array)} ");