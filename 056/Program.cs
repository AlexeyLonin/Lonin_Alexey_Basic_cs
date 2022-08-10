// 56. Написать программу, которая обменивает элементы первой строки
// и последней строки

void SetArray2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 20);
        }
    }
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine();
    }
}

void Solve(int[,] arr)
{
    int tmp;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i==0 || i==3)
            {
            tmp=arr[i,j];
            arr[i,j]=arr[i,j];
            arr[i,j]=tmp;
            }
    }
    }
}
int m = 4;
int n = 4;
int[,] arr;
arr = new int[m, n];

SetArray2D(arr);
Print(arr);
Solve(arr);

System.Console.WriteLine();
Print(arr);