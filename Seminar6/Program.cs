/*
Задача 39: Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] 
*/
/*
int[] GetArray(int size, int minVal, int maxVal)
{
    int[] res = new int[size];
    for(int i =0; i<size; i++)
    {
        res[i] = new Random(). Next(minVal, maxVal);
    }
    return res;
}

void RevArray1(int[] inArray) // первый метод переворота массива 
{
    for(int i =0; i<inArray.Length /2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length -1 -i];
        inArray[inArray.Length -1 -i] = k;
    }
}

int[] RevArray2(int[] inArray) // второй метод переворота массива
{
    int[] result = new int[inArray.Length];
    for(int i =0; i<inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length -1 -i];
    }
    return result;
}
int[] array = GetArray(9,0,10); 
Console.WriteLine(string.Join(" ", array)); // это метод только для одномерных массивов
Console.WriteLine();
//RevArray1(array); 
//Console.WriteLine(string.Join(" ", array));
int[] revArray = RevArray2(array);
Console.WriteLine(string.Join(" ", revArray)); */


/*
Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

/*
void GetTriangle(int a, int b, int c)
{
    if (a >0 && b >0 && c >0)
    {
        if(a <b+c && b <a+c && c <a+b)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
Console.WriteLine("Enter num: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
GetTriangle(num1, num2, num3); 
*/

/*
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

/*
void GetNum(int num)
{

    int remains =0;
    string res = string.Empty; // обозначение пустой строки, так же можно записать вот так -""
    while(num>0)
    {
        remains = num %2; // здесь деление с остатком на 2 
        res = remains + res; 
        num = num /2; // здесь деление числа для дальнейшей передачи в цикл
    }
    Console.WriteLine(res);
}
Console.WriteLine("Enter num: ");
int num = int.Parse(Console.ReadLine());
GetNum(num);
*/


/*
Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

/*
void FibNum(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    Console.Write($"{array[0]} {array[1]} ");
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i -1]+array[i -2];
        Console.Write($"{array[i]} ");
    }
}    
Console.WriteLine("Input length array - ");
int num = int.Parse(Console.ReadLine());
FibNum(num);
*/


/*
Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.
*/

void FillArray(int[] massiv){
for (int i = 0; i < massiv.Length; i++)
{
Random rnd = new Random();
massiv[i] = rnd.Next(1, 100);
}
}

void PrintArray(int[] massiv){

for (int i = 0; i < massiv.Length; i++)
{
Console.WriteLine($"[{i}] = {massiv[i]}");
}
Console.WriteLine();
}


int[] GetArray(int[] massiv){
int length = massiv.Length; // Старый массив
int[] massiv1 = new int[length];// Новый массив
for (int i = 0; i < length; i++)
{
massiv1[i] = massiv[i];
}
return massiv1;
}

void DeepCopy(){

int[] massiv = new int[10];
FillArray(massiv); // Заполнение массива
System.Console.WriteLine("\nНаш массив:");
PrintArray(massiv); // Вывод массива
int[] newMassiv = GetArray(massiv);
System.Console.WriteLine("\nНовый массив:");
PrintArray(newMassiv); // Вывод массива
}
DeepCopy();

