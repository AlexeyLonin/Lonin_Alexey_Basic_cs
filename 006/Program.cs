// See https://aka.ms/new-console-template for more information

 double f(double x)
{
    double k;
    if (Math.Sin(x) < 0)
        k = x*x;
    else
        k = Math.Abs(x);
    
    if (k < x)
        return k * x;
    else
        return k + x;
}
