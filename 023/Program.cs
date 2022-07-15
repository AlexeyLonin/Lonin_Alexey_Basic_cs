// 23. Найти расстояние между точками в пространстве 2D
double distance(double x1, double y1, double x2, double y2)
{
    double d;
    d=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y2,2));
    return d;
}

double x1=0, y1=0, x2=5, y2=4;

System.Console.WriteLine(distance(x1, x2, y1, y2));
