﻿// 10.	Показать последнюю цифру трёхзначного числа
System.Console.WriteLine();

int number = new Random().Next(100, 1000);

System.Console.WriteLine($"Последней цифрой числа {number} является цифра {number%10}");
System.Console.WriteLine();
