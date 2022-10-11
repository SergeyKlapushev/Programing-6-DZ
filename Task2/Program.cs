/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
 
const int x = 0;
const int y = 1;
const int z = 2;

int [] Coordinates(string message)
{
    Console.WriteLine(message);
    int [] array = new int[3];
    array[x] = Promt("Введите X: ");
    array[y] = Promt("Введите Y: ");
    array[z] = Promt("Введите Z: ");
    return array;
}

int Promt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int Square (int arg)
{
    return arg * arg;
}

double Raschet(int[] p1, int[] p2)
{
    double otvet = Math.Sqrt(Square(p1[x]-p2[x]) + Square(p1[y]-p2[y]) + Square(p1[z]-p2[z]));
    return otvet;
}

int [] point1 = Coordinates("Введите координаты первой точки: ");
int [] point2 = Coordinates("Введите координаты второй точки: ");
double distans = Raschet(point1, point2); 
Console.WriteLine($"{distans:f2}");