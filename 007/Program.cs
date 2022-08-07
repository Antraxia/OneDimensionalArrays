// Даны N отрезков прямой. Найти длину общей части всех этих отрезков.

int n=int.Parse(Console.ReadLine());
int min=30001;
int max=-1;
int a=0,b=0;
for(int i=0;i<n;i++)
{
    string[] ss=Console.Readline().Split(' ',StringSplitOptions.RemoveEmptyEntries);
     a=int.Parse(ss[0]);
     b=int.Parse(ss[1]);
    if(a>max) max=a;
    if(b<min) min=b;
}
System.Console.WriteLine(min-max);
