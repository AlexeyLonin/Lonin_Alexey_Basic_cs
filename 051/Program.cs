// 051. Создать подпрограмму Create2DArray(m,n)
// которая возвращает двумерный массив следующим правилом: Aij = i+j

void SetArray2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i+j;
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


int m = 10;
int n = 5;
int[,] arr;
arr = new int[m, n];

SetArray2D(arr);
Print(arr);