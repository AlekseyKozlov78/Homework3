// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите целое число");
int n = int.Parse(Console.ReadLine());
double Result(int iLocal)
{
     return Math.Pow(iLocal, 3);
}
for (int i = 1; i <= n; i = i + 1)
{
    Console.WriteLine(Result(i));
}


