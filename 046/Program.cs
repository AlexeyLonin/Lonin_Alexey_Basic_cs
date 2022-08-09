// 046. С клавиатуры вводится число N. 
// Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int perv = 1;
Console.Write("{0} ", perv);
int vtor = 1;
Console.Write("{0} ", vtor);
int sum = 0;

while (number >= sum)
    {     sum = perv + vtor;            
      Console.Write("{0} ", sum);                
     perv = vtor;
     vtor = sum;                
                
    }