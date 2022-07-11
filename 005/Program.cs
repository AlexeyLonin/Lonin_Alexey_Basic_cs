// 5.	Найти максимальное из трех чисел
int[] Numbers = { 54, 69, 8 };

for (int i = 0; i < 3; i++)
{
    int max = Numbers[0];
    
    if (Numbers[i] > max)
    {
        max = Numbers[i];
        System.Console.WriteLine();
        System.Console.WriteLine($"Максимальное число {max}");
    }
}
System.Console.WriteLine();
