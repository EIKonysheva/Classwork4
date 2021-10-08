using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Classwork4
{
    class Program
    {
        
        static void DrawDigit(int k1, Bitmap[] images)
        {
            for (int i = 0; i < images[k1].Height; i++)
            {
                for (int j = 0; j < images[k1].Width; j++)
                {
                    if (images[k1].GetPixel(j, i) == Color.FromArgb(255, 255, 255, 255))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }

                }
                Console.WriteLine();
            }
        }
                static void SolveTheEquation()
        {
            Console.WriteLine("Введите коэффициенты a,b,c");
            double coefficient_a = Convert.ToDouble(Console.ReadLine());
            double coefficient_b = Convert.ToDouble(Console.ReadLine());
            double coefficient_c = Convert.ToDouble(Console.ReadLine());
            double diskriminant = coefficient_b * coefficient_b - 4 * coefficient_a * coefficient_c;
            if (diskriminant < 0)
            {
                Console.WriteLine("Нет вещественных корней");
            }
            else if (diskriminant == 0)
            {
                double x = -coefficient_b / 2 * coefficient_a;
                Console.WriteLine($"x = {x}");
            }
            else
            {
                double x1 = (-coefficient_b - Math.Sqrt(diskriminant)) / 2 * coefficient_a;
                double x2 = (-coefficient_b + Math.Sqrt(diskriminant)) / 2 * coefficient_a;
                Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
            }
        }
        static void OutputAnArray(ref int[] number20)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"number20[{i}] = {number20[i]}");
            }
        }
        static void BubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        static int SumArray(params int[] massiv)
        {
            int sumMassiv = 0;
            for (int i = 0; i < massiv.Length; i++)
            {
                sumMassiv += massiv[i];
            }
            return sumMassiv;
        }
        static long MultiplyArray(ref int[] massiv)
        {
            long multMassiv = 1;
            for (int i = 0; i < massiv.Length; i++)
            {
                multMassiv *= massiv[i];
            }
            return multMassiv;
        }
        static void AverageArray(int[] massiv, out double averageMassiv)
        {


            averageMassiv = SumArray(massiv) / massiv.Length;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            SolveTheEquation();
            Console.WriteLine("Задание 2");
            Random rnd = new Random();
            int[] number20 = new int[20];
            for (int i = 0; i < 20; i++)
            {
                number20[i] = rnd.Next(1, 99);
                Console.WriteLine($"number20[{i}] = {number20[i]}");
            }

            Console.WriteLine("Введите номера чисел, которые надо поменять");
            int k1 = Convert.ToInt32(Console.ReadLine());
            int k2 = Convert.ToInt32(Console.ReadLine());
            if (k1 < 20 && k1 >= 0 && k2 < 21 && k2 >= 0)
            {
                int k = number20[k2];
                number20[k2] = number20[k1];
                number20[k1] = k;
            }
            else
            { Console.WriteLine("Ошибка ввода"); }
            OutputAnArray(ref number20);
            Console.WriteLine("Задание 3");
            BubbleSort(number20);
            OutputAnArray(ref number20);
            Console.WriteLine("Задание 4");
            Console.WriteLine($"Сумма = {SumArray(number20)}");
            Console.WriteLine($"Произведение = {MultiplyArray(ref number20)}");
            double averageMassiv;
            AverageArray(number20, out averageMassiv);
            Console.WriteLine($"Cреднее значение = {averageMassiv}");
            Console.WriteLine("Задание 5");
            Bitmap[] images =
               {
                new Bitmap(@"0.png"),
                new Bitmap(@"1.png"),
                new Bitmap(@"2.png"),
                new Bitmap(@"3.png"),
                new Bitmap(@"4.png"),
                new Bitmap(@"5.png"),
                new Bitmap(@"6.png"),
                new Bitmap(@"7.png"),
                new Bitmap(@"8.png"),
                new Bitmap(@"9.png"),
            };
        Input:
            try
            {
                Console.WriteLine("Введите число или выход/exit, чтобы выйти из программы:");     
                string vvod = Console.ReadLine(); 
                    if(vvod.ToLower() == "выход" || vvod.ToLower() == "exit")
                { Console.WriteLine("Вы вышли из программы"); }
                   else  
                {
                    k1 = Int32.Parse(vvod);
                    switch (k1)
                    {
                        case 0:
                            {
                                DrawDigit(0, images);
                                break;
                            }
                        case 1:
                            {
                                DrawDigit(1, images);
                                break;
                            }
                        case 2: 
                            {
                                DrawDigit(2, images);
                                break;
                            }
                        case 3:
                            {
                                DrawDigit(3, images);
                                break;
                            }
                        case 4:
                            {
                                DrawDigit(4, images);
                                break;
                            }
                        case 5:
                            {
                                DrawDigit(5, images);
                                break;
                            }
                        case 6:
                            {
                                DrawDigit(6, images);
                                break;
                            }
                        case 7:
                            {
                                DrawDigit(7, images);
                                break;
                            }
                        case 8:
                            {
                                DrawDigit(8, images);
                                break;
                            }
                        case 9:
                            { 
                                DrawDigit(9, images);
                                break;
                            }
                            
                        default:
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Thread.Sleep(3000);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                break;
                            }
                   }
                    goto Input;
                }              
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Input;
            } 
        }
    }
}
