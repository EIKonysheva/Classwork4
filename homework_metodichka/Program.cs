using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_metodichka
{
    class Program
    {
         static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        static int NOD(int k1, int k2)
        {
            while(k1!=k2)
            {
                if(k1>k2)
                {
                    k1 -= k2;
                }
                else
                {
                    k2 -= k1;
                }
            }
            return k2;
        }
        static int NOD(int k,int k1, int k2)
        {
            while (k != k2)
            {
                if (k > k2)
                {
                    k -= k2;
                }
                else
                {
                    k2 -= k;
                }

                while (k1 != k2)
                {
                    if (k1 > k2)
                    {
                        k1 -= k2;
                    }
                    else
                    {
                        k2 -= k1;
                    }
                }               
            }
            return k;
        }
        static int RecFactorial(int k)
        {
            try
            {
                if (k == 0) return 1;
                return k * RecFactorial(k - 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        static int CompareNumbers(int num1, int num2)
        {      
            if (num1 > num2)
                {                   
                return num1;
                }
                else
                {
                return num2;
                }
        }
        static void ReplaceNumbers(ref int number1, ref int number2)
        {
            int n = number2;
            number2 = number1;
            number1 = n;
        }
        static bool Factorial(int k, out int fact)
        {
            fact = 1;
            try
            {
                for (int i = k; i > 1; i--)
                {
                    fact = checked(fact * i);
                }
                return true;
            }
            catch (System.OverflowException ex)
            {
                return false;
            }
        }
         static void Main(string[] args)
        {
            Console.WriteLine("Задание 5.1\nВведите 2  целых числа, которые хотите сравнить");
            try
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Большее число {CompareNumbers(num1, num2)}");
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }
            Console.WriteLine("Задание 5.2\nВведите 2 числа");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            ReplaceNumbers(ref number1, ref number2);
            Console.WriteLine($"{number1} {number2}");
            Console.WriteLine("Задание 5.3\nВведите число, факториал которого нужно посчитать");
            int k = Convert.ToInt32(Console.ReadLine());
            int fact;
            Console.WriteLine(Factorial(k, out fact));
            if(Factorial(k, out fact))
            {
                Console.WriteLine(fact);
            }
            else
                Console.WriteLine("Переполнение");
            Console.WriteLine("Задание 5.4\nВведите число, факториал которого нужно посчитать (рекурсивный метод)");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"factorial = {RecFactorial(k)}");
            Console.WriteLine("Задание 5.1\nВведите 2 числа, у которых нужно вычислить НОД");
            int k1 = Convert.ToInt32(Console.ReadLine());
            int k2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"НОД = {NOD(k1,k2)}" +
                $"\nВведите 3 числа, у которых нужно вычислить НОД");
            k1 = Convert.ToInt32(Console.ReadLine());
            k2 = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"НОД = {NOD(k1, k2, k)}" +
                $"\nЗадание 5.2 (Фибоначчи)\nВведите номер члена последовательности");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"n-й член последовательности = {Fibonacci(k)}");
        }
    }
}
