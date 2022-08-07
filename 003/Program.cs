// Вводится сначала число N, а затем N чисел.
// Выведите эти N чисел в следующем порядке: сначала выводятся числа, стоящие на нечетных местах, а затем - стоящие на четных местах.
 //Нумерация элементов начинается с 1. Входные данные
//Вводится число N (100>N>0), а затем N чисел из диапазона Integer.
using System;

int N=int.Parse(Console.ReadLine());
string s=Console.ReadLine();
string[] ss=s.Split(' ');

/*
int[] a=new int[ss.Length];
//Школьный вариант
for(int i=0;i<ss.Length;i++)
{
    a[i]=int.Parse(ss[i]);
}
*/

//конвертирует массив строк в массив целых чисел
int[] a=Array.ConvertAll<string,int>(ss,int.Parse);

for(int i=1;i<a.Length;i=i+2)
{
    System.Console.Write($"{a[i]} ");
}
for(int i=0;i<a.Length;i=i+2)
{
    System.Console.Write($"{a[i]} ");
}