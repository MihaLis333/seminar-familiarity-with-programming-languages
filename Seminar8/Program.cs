/*
Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
*/
/*
int[,] GetArray(int r, int c)
{
    int[,] result = new int[r, c];
    for(int i =0; i < r; i++)
    {
        for(int j =0; j < c; j++)
        {
            result[i, j] = new Random().Next(1, 10);
            //Console.Write($"{result[i,j]} ");
        }
        //Console.WriteLine();
    }
    return result;
}

void PrintArray(int[,] pArray)
{
    for(int r =0; r < pArray.GetLength(0); r++)
    {
        for(int c =0; c < pArray.GetLength(1); c++)
        {
            Console.Write($"{pArray[r,c]} ");
        }
        Console.WriteLine();
    }
}

void SwapLines(int[,] sArray)
{
    int temp =0;
    for(int r =0; r < sArray.GetLength(1); r++)
    {
        temp = sArray[0, r];
        sArray[0, r] = sArray[sArray.GetLength(0)-1, r];
        sArray[sArray.GetLength(0)-1, r] = temp;
    }

}

int[,] array = GetArray(5, 6);
PrintArray(array);
Console.WriteLine();
SwapLines(array);
PrintArray(array); */

/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/


int[,] GetArray(int r, int c)
{
    int[,] result = new int[r, c];
    for(int i =0; i < r; i++)
    {
        for(int j =0; j < c; j++)
        {
            result[i, j] = new Random().Next(1, 10);
            //Console.Write($"{result[i,j]} ");
        }
        //Console.WriteLine();
    }
    return result;
}

void PrintArray(int[,] pArray)
{
    for(int r =0; r < pArray.GetLength(0); r++)
    {
        for(int c =0; c < pArray.GetLength(1); c++)
        {
            Console.Write($"{pArray[r,c]} ");
        }
        Console.WriteLine();
    }
}

void ReplaceRowsWithColumns(int[,] rArray)
{
    int[,] TransArray = new int[rArray.GetLength(0), rArray.GetLength(1)];
    for(int i =0; i < rArray.GetLength(0); i++)
    {
        for(int j =0; j < rArray.GetLength(1); j++)
        {
            TransArray[i, j] = rArray[j, i];
            Console.Write($"{TransArray[i,j]} ");
        }
    }
    
}

int[,] array = GetArray(2,2);
PrintArray(array);
Console.WriteLine();
ReplaceRowsWithColumns(array);
//PrintArray(array);

/*if(Proverka(matrix, row, col)){
NewMatrix(matrix,row, col);
Console.WriteLine("Новый массив");
PrintIntMatrix(matrix);
}
else{
Console.WriteLine("Нев*/
