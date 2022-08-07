//Вводится сначала число N, а затем N чисел. Выведите эти N чисел в обратном порядке.

//Входные данные
//Вводится число N (100>N>0), а затем N чисел из диапазона Integer.

//Выходные данные
//Выведите N чисел в обратном порядке
using System;

int N=int.Parse(Console.ReadLine());
string s=Console.ReadLine();
string[] ss=s.Split(' ');
for(int i=ss.Length-1;i>=0;i--)
{
    System.Console.Write($"{ss[i]} ");
}