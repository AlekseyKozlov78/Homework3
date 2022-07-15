// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine ("Введите пятизначное число");
string str = Console.ReadLine();

string CheckPalindrom(string strLocal)
{
if (strLocal[0] == strLocal[4] && strLocal[1] == strLocal[3]) return "Число является палиндромом";
else return "Число не является палиндромом";
}

int n = str.Length;
if (n == 5) Console.WriteLine(CheckPalindrom(str));
else Console.WriteLine("Вы ввели не пятизначное число");