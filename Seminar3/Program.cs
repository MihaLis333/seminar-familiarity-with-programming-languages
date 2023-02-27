/* Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка. */

/*Console.WriteLine("Введите точку X "); double x = double.Parse(Console.ReadLine());

Console.WriteLine("Введите точку Y "); double y = double.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("1 quarter");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("2 quarter");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("3 quarter");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("4 quarter");
} */

/* Задача 18. Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек в этой четверти (x и y). */

/*Console.WriteLine("Input number qurter");
double num = double.Parse(Console.ReadLine());

if (num == 1)
{
   Console.WriteLine("x and y");
}
if (num == 2)
{
   Console.WriteLine("-x and y");
}
if (num == 3)
{
   Console.WriteLine("-x and -y");
}
if (num == 4)
{
   Console.WriteLine("x and -y");
} */


/* Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояниемежду ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

/* Console.Write("Input coordinat point Xa: ");
double xa = double.Parse(Console.ReadLine());
Console.Write("Input coordinat point Ya: ");
double ya = double.Parse(Console.ReadLine());

Console.Write("Input coordinat point Xb: ");
double xb = double.Parse(Console.ReadLine());
Console.Write("Input coordinat point Yb: "); 
double yb = double.Parse(Console.ReadLine());

double ac = xb - xa; 
double bc = yb - ya; 
double ac2 = Math.Pow(ac, 2); 
double bc2 = Math.Pow(bc, 2);


Console.WriteLine($"{Math.Sqrt(ac2 + bc2)}"); */

/* Task 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
квадратов чисел
от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

/*Console.Write("Input num: ");
int num = int.Parse(Console.ReadLine());
int count = 1;
while (count <= num)
{
    int result = count * count;
    Console.WriteLine(result);
    count++;
} */
