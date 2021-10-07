using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Program
    {
        static void Biggest(int a, int b)
        {
            if (a>b)
            {
                Console.WriteLine("The biggerst is :" + a);
            }
            else if(a<b)
            {
                Console.WriteLine("The biggest is :"+b);
            }
            else
            {
                Console.WriteLine("они равны");
            }

        }
        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        static int Factor(int number)
        {
            int factorial = 1;
            for (int i = 1; i < number; i++)
            {
             factorial = checked(factorial*i);
            }
            return factorial;
        }

        static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return checked(number * Factorial(number- 1));
            }
        }
        static int NOD(int n1, int n2)
        {
            while (n1 != n2)
            {
                if (n1 > n2)
                {
                    n1 = n1 - n2;
                }
                else
                {
                    n2 = n2 - n1;
                }
            }
           return n2;
        }

        static int NOD(int n1, int n2, int n3)
        {
           n3 = NOD(NOD(n1, n2),n3);
            return n3;
        }

        static int Fibonachi(int n)
        {
                if (n == 0 || n == 1)
                {
                    return n;
                }
                else
                {
                    return Fibonachi(n - 1) + Fibonachi(n - 2);
                }
            
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("task 5.1");
            Console.WriteLine("input 2 numbers: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Biggest(a, b);

            Console.WriteLine("task 5.2");
            Console.WriteLine("input 2 numbers : ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("a --> {0}; b --> {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("a --> {0}; b --> {1}", a, b);


            Console.WriteLine("task 5.3");
            Console.Write("введите а для вычилсения a! : ");
            try
            {
                    int n = int.Parse(Console.ReadLine());                    
                    Console.WriteLine(Factor(n));
                
            }
            catch(OverflowException)
            {
                Console.WriteLine("you got a overflow situation");
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("task 5.4");
            Console.Write("введите а для вычилсения a! : ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Факториал равен : " + Factorial(n));

            }
            catch (OverflowException)
            {
                Console.WriteLine("you got a overflow situation");
            }

            Console.WriteLine("home task 5.1");
            Console.WriteLine("input 2 numbers to get NOD of 2 :");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("NOD = "+NOD(n1,n2));
            Console.WriteLine("input 3 numbers to get NOD of 3 :");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("NOD = " + NOD(n1, n2,n3));

            Console.WriteLine("home task 5.2");
            Console.WriteLine("input n : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number}-ый член последовательности Фиббоначи :"+Fibonachi(number));

        }

    }
}
