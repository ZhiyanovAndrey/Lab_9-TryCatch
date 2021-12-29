using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_TryCatch
{
    /* 9.1.Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, 
     * а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). 
     * После этого на консоль выводится ответ. 
     * Используйте обработку исключений для защиты от ввода некорректных данных.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!!!");
            bool repeat = true;
              
            while (repeat)
            {

                double total;
                try
                {
                    Console.WriteLine("Введите первое число например 2,5");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите действие: * или / или + или -");
                    char sign = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double b = Convert.ToDouble(Console.ReadLine());

                    if (sign == '/' || sign == '*' || sign == '+' || sign == '-')
                    {
                        if (sign == '*')
                        {
                            total = a * b;
                            Console.WriteLine("Результат умножения: " + total);
                        }
                        if (sign == '/')
                        {
                            total = a / b;
                            Console.WriteLine("Результат деления: " + total);
                        }
                        if (sign == '+')
                        {
                            total = a + b;
                            Console.WriteLine("Результат сложения: " + total);
                        }
                        if (sign == '-')
                        {
                            total = a - b;
                            Console.WriteLine("Результат вычитания: " + total);
                        }
                    }
                    else Console.WriteLine("Нет операции с указанным символом");

 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Входная строка имела не верный формат");
                }


                catch (Exception err) //в переменную err помешается инфо о возникшем исключении
                {
                    Console.WriteLine(err.Message);
                }
                  
                Console.WriteLine("Если хотите продолжить нажмите: д " +
                        "Если нет любой символ и нажмите клавишу Enter");
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "Д")
                    {
                        repeat = false;
                    }
            }
            Console.ReadKey();
        }
    }
}
