// 3. Даны два числа. Показать большее и меньшее число
double a,b;
string? s=Console.ReadLine();
a=Convert.ToDouble (s);
s=Console.ReadLine();
b=Convert.ToDouble(s);


if (a == b)
{
Console.WriteLine("Равны");
}
else 
if(a>b)
{
Console.WriteLine(a);
Console.WriteLine(b);
}
else
{
Console.WriteLine(b);
Console.WriteLine(a);
}
