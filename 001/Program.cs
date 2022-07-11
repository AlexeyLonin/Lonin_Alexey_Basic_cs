/*int a=2, b=3; //операция присваивания
int s=a+b;
Console.WriteLine(a+"+"+b+"="+s); //склеивание строк

Console.WriteLine("{2}+{1}={0}",s,b,a); //строка форматирования

Console.WriteLine($"{a}+{b}={s}"); //строка интерполяции
*/




//Ввести с клавиатуры целое число и вывести квадрат этого числа на экран

double a;
double b;
string? s;
Console.Write("Введите число: ");
s=Console.ReadLine();
a=Convert.ToDouble(s);
b=a*a;
System.Console.WriteLine($"{a}^2={b}");