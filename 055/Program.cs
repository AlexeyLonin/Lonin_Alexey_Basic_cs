// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
Console.WriteLine("Введите значение n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение m:");
int m = Convert.ToInt32(Console.ReadLine());
int [,]arr=new int [n, m];
int []sum=new int [m];
Random ran = new Random();

for (int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        arr[i, j] = ran.Next(0, 100);

        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i=0; i<m; i++)
{
    for(int j=0; j<n; j++)
    {
        sum[i] += arr[j, i];
    }
}

for (int i=0; i<m; i++)
{
    Console.Write((sum[i] / n)  + " ");
}
Console.ReadLine();