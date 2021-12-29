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
            Console.WriteLine("Вас приветствует калькулятор");
            char again = 'д';
            while (again == 'д')
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
                catch (ArgumentException)
                {
                    Console.WriteLine("Недопустимый символ");
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
                Console.WriteLine("Если хотите продолжить нажмите: д. Если нет любой символ и нажмите Enter");
                again = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
