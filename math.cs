using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    class Program
    {
        static int a;
        static int b;
        static int result;
        static Random r = new Random();
        static int answer;



        static void Main(string[] args)
        {
            Task();
            Check();
            CheckAnswer();

        }

        static void Check()
        {
            bool correct = false;
            while (!correct)
            {
                Console.WriteLine($"Введите число");
                correct = int.TryParse(Console.ReadLine(), out answer);

            }

        }


        static void CheckAnswer()
        {
            //Console.WriteLine($"  {answer}");

            //Console.WriteLine($"  {result}");
            for (int i = 0; i < 2; i++)
            {
                if (answer != result)
                {
                    Console.WriteLine("Попробуй еще раз");
                    Check();
                }

                else
                {
                    Console.WriteLine("МОЛОДЕЦ!");
                    break;
                }
            }
            if (answer != result)
            {
                Console.WriteLine($"Правильный ответ: {result} ");
            }
        }


        static void Task()
        {
            switch (r.Next(1, 5))
            {
                case 1:// сложение
                    a = r.Next(1, 11);
                    b = r.Next(1, 11);
                    result = a + b;

                    Console.WriteLine($"{a} + {b} =    ? ");
                    break;

                case 2://вычитание
                    a = r.Next(1, 11);
                    b = r.Next(1, 11);
                    result = Math.Max(a, b) - Math.Min(a, b);

                    Console.WriteLine($"{Math.Max(a, b)} - {Math.Min(a, b)} =     ? ");
                    break;

                case 3:// умножение
                    a = r.Next(1, 11);
                    b = r.Next(1, 11);
                    result = a * b;

                    Console.WriteLine($"{a} * {b} =     ? ");
                    break;

                case 4:// деление
                    do
                    {
                        a = r.Next(1, 11);
                        b = r.Next(1, 11);
                    } while (a % b != 0);

                    result = a / b;

                    Console.WriteLine($"{a} / {b} =     ? ");

                    break;
            }
        }


    }
}
