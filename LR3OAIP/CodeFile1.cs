using System;
using System.Diagnostics;
using System.IO;

namespace LR3OAIP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант 31
            Console.WriteLine("Файл input находится в @/LR3OAIP/LR3OAIP/bin/Debug");
            Console.WriteLine("Файл output.txt находится в @/LR3OAIP/LR3OAIP/bin/Debug");
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            double N, Z = 0, o;
            double X, Y;
            o = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            X = Convert.ToDouble(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());

            switch (o)
            {
                case 1:
                    {
                        int a = 2, b = 3, c = 1;
                        for (int i = 1; i <= N; i++)
                        {
                            if (i % 2 == 1)
                            {
                                Z = Z + ((Math.Pow(X, a) * Math.Log10(Y)) / (c * b));
                                a = a * 2;
                                b = b + 2;
                                c = c + 2;
                            }
                            else
                            {
                                Z = Z - ((Math.Pow(Y, a) * Math.Log10(X)) / (c * b));
                                a = a * 2;
                                b = b + 2;
                                c = c + 2;
                            }
                        }
                        Console.WriteLine(String.Format("{0:0.00000}", Z));
                        break;
                    }
                case 2:
                    {
                        int a = 2, b = 3, c = 1;
                        int j = 1;
                        while (j <= N)
                        {
                            if (j % 2 == 1)
                            {
                                Z = Z + ((Math.Pow(X, a) * Math.Log10(Y)) / (c * b));
                                a = a * 2;
                                b = b + 2;
                                c = c + 2;
                            }
                            else
                            {
                                Z = Z - ((Math.Pow(Y, a) * Math.Log10(X)) / (c * b));
                                a = a * 2;
                                b = b + 2;
                                c = c + 2;
                            }
                            j++;
                        }
                        Console.WriteLine(String.Format("{0:0.00000}", Z));
                        break;
                    }
                case 3:
                    {
                        int a = 2, b = 3, c = 1;
                        int g = 1;
                        do
                        {
                            if (g % 2 == 1)
                            {
                                Z = Z + ((Math.Pow(X, a) * Math.Log10(Y)) / (c * b));
                                a = a * 2;
                                b = b + 2;
                                c = c + 2;
                            }
                            else
                            {
                                Z = Z - ((Math.Pow(Y, a) * Math.Log10(X)) / (c * b));
                                a = a * 2;
                                b = b + 2;
                                c = c + 2;
                            }
                            g++;
                        }
                        while (g <= N);
                        Console.WriteLine(String.Format("{0:0.00000}", Z));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка, вы ввели неверные указания в переменной t. Измените значения данной переменной.");
                        break;
                    }
            }
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}