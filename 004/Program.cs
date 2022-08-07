// Вводится число N, а затем - N чисел.
//Определить, сколько среди них пар одинаковых чисел.

using System;
Console.ReadLine();
string s=Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss,int.Parse);

int c=0;
for(int i=0;i<a.Length;i++)
{
    for(int j=i+1;j<a.Length;j++)
    {
        if(a[i]==a[j]) c++;
    }
}
System.Console.WriteLine(c);