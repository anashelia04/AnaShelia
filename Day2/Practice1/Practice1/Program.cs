int a = 5;
int b = 6;
int c = a;
a = b;
b = c;

Console.WriteLine(a);
Console.WriteLine(b);

int x= 5;
int y= 10;

(x,y) = (y, x);

Console.WriteLine(x);
Console.WriteLine(y);
