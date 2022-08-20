// 3. С клавиатуры вводится строка, разделенная точкой.
// Подсчитать количество символов до точки
{
    Console.Write("Введите текст: ");
    string text = Console.ReadLine();
    int before = text.IndexOf('.');
 
    Console.WriteLine($"До точки {before} символов");
}