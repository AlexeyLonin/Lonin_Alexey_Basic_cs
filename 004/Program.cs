// 4.	По заданному номеру дня недели вывести его название
Console.Write("Введите день недели ");
                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {
                        case 1: Console.WriteLine("Понедельник");
                            break;
                        case 2: Console.WriteLine("Вторник");
                            break;
                        case 3: Console.WriteLine("Среда");
                            break;
                        case 4: Console.WriteLine("Четверг");
                            break;
                        case 5: Console.WriteLine("Пятница");
                            break;
                        case 6: Console.WriteLine("Суббота");
                            break;
                        case 7: Console.WriteLine("Воскресенье");
                            break;
                        default:
                            Console.WriteLine("Такого номер дня недели нет");
                            break;
                    }
                }
            catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
