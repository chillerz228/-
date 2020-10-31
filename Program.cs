using System;

namespace isrpo_1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int N; int a; int i;
            int[] max = new int[] { 0,1 };
            int[] max19 = new int[] { 0,1 };
            max[0] = 0; max[1] = 1;
            max19[0] = 0; max19[1] = 1;
            try
            {
                Console.WriteLine("Введите количество шагов в цикле");
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("invalid data type");
            }
            try
            {
                if (N <= 0)
                { Console.WriteLine("Пожалуйста, введите число больше 1 или равное 1"); }
                if (N >= 1)
                    Console.WriteLine("Введено успешно");
            }
            catch
            {
                Console.WriteLine("Неверные данные, неверно, пожалуйста перепроверьте");
            }
            for (i = 1; i <= N; i++)
            {   
                a = Convert.ToInt32(Console.ReadLine());
                if ((a % 19 == 0) && (a % 2 == 0) && (a >= max19[0]))
                {
                    if (max19[0] < max[0])
                    { max[1] = max19[1]; }
                    max19[0] = a;
                }
                else if ((a % 19 == 0) && (a % 2 == 1) && (a >= max19[1]))
                {
                    if (max19[1] > max[1])
                    { max[1] = max19[1]; }
                    max19[1] = a;
                }
                else if ((a % 19 > 0) && (a % 2 == 0) && (a > max[0]))
                { max[0] = a; }
                else if ((a % 19 > 0) && (a % 2 == 1) && (a > max[1]))
                { max[1] = a; }
                if ((max[0] == 0) || (max19[0] == 0))
                { max[0] = 0; max19[0] = 0; }
                if ((max[1] == 0) || (max19[1] == 0))
                { max[1] = 0; max19[1] = 0; }
                if((max[0] + max19[0]) > (max[1] + max19[1]))
                    Console.WriteLine("{0} {1}",max[0], max19[0]);
                else Console.WriteLine("{0} {1}", max[1], max19[1]);

            }

        }
    }
}
