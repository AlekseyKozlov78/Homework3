//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите xa");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ya");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Введите za");
int za = int.Parse(Console.ReadLine());
Console.WriteLine("Введите xb");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите yb");
int yb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите zb");
int zb = int.Parse(Console.ReadLine());

//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
double Distance (int xaLocal, int yaLocal, int zaLocal, int xbLocal, int ybLocal, int zbLocal)
{
  double Dis = Math.Sqrt(Math.Pow((xbLocal-xaLocal),2) + Math.Pow((ybLocal - yaLocal),2) + Math.Pow((zbLocal-zaLocal),2));
  return Dis;
}
Console.WriteLine(Distance (xa, ya, za, xb, yb, zb));