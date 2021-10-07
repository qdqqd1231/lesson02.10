using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace classwork
{
    class Program   
    {

        static void QuadraticSolution(double a, double b, double c)
        {
            double d, x1, x2;
            d = (b * b - 4 * a * c);
            if (d >= 0)
            {
                x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine($"Корни квадратного уравнения : {x1} и {x2}");
            }
            else
            {
                Console.WriteLine("Корней нет!");
            }
        }
        static int[] BubbleSort(int[] arrey)
        {
            int temp;
            for (int i = 0; i < arrey.Length; i++)
            {
                for (int j = i + 1; j < arrey.Length; j++)
                {
                    if (arrey[i] > arrey[j])
                    {
                        temp = arrey[i];
                        arrey[i] = arrey[j];
                        arrey[j] = temp;
                    }

                }
            }
            return arrey;
        }

        static int Sum(params int[] arr)
        {
            int sum=0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static void Product(ref int product, params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
        }

        static void Avarage(out double avarage, params int[] arr)
        {
            avarage = Sum(arr) / arr.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("task 1");
            Console.Write("Введите коэффициенты a, b, c квадратного уравнения a*x^2+b*x+c : ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            QuadraticSolution(a, b, c);

            Console.WriteLine("task 2");
            int[] arr = new int[20];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next();
                Console.Write(arr[i] + "\n");
            }
            Console.WriteLine("Введите числа, которые хотите заменить по очереди ");
            Console.Write("Первое число : ");
            int value_1 = int.Parse(Console.ReadLine());
            int value_1copy = value_1;
            Console.Write("Второе число : ");
            int value_2 = int.Parse(Console.ReadLine());
            int value_2copy = value_2;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value_1)
                {
                    arr[i] = value_2copy;
                    Console.Write(arr[i] + "\n");
                    continue;
                }
                if (arr[i] == value_2)
                {
                    arr[i] = value_1copy;
                }
                Console.Write(arr[i] + "\n");
            }
            Console.WriteLine("task 3");

            Console.WriteLine("Введите размер одномерного массива : ");
            int n = int.Parse(Console.ReadLine());
            int[] arrey = new int[n];
            r = new Random();
            for (int i = 0; i < arrey.Length; i++)
            {
                arrey[i] = r.Next(0,100);
                Console.Write(arrey[i] + "\n");
            }
            BubbleSort(arrey);
            Console.WriteLine("Отсортированный массив : ");
            for (int i = 0; i < arrey.Length; i++)
            {
                Console.Write(arrey[i] + "\n");
            }
            Console.WriteLine();

            Console.WriteLine("task 4");
            double avarage;
            int product = 1;
            int sum = Sum(arrey);
            Console.WriteLine("sum of arrey : "+sum);
            Product(ref product, arrey);
            Console.WriteLine("произведение : "+product);
            Avarage(out avarage, arrey);
            Console.WriteLine("среднее арифметическое : "+avarage);
            Console.Clear();

            Console.WriteLine("task 5");
            Console.WriteLine("введите число от 0 да 9 : ");
            string str = Console.ReadLine().ToLower();
            bool flag = true;
            bool run = true;
            while (flag)
            {
                if(!run)
                {
                    Console.WriteLine("Введите число от 0 до 9. Если хотите завершить, напишите exit или закрыть!");
                    str = Console.ReadLine().ToLower();
                    Console.Clear();
                }
                else
                {
                    run = false;
                }
                try
                {
                    Console.Clear();
                    if ((str == "exit") || (str == "закрыть"))
                    {
                        flag = false;
                        break;
                    }
                    int number = int.Parse(str);
                    if (number < 0 || number > 9)
                    {
                        throw new Exception("Вы ввели неплавильное число!");
                    }
                    switch (number)
                    {

                        case 0:
                            Console.WriteLine(" ##\n#  #\n#  #\n#  #\n ##");
                            break;
                        case 1:
                            Console.WriteLine("  #\n ##\n# #\n  #\n  #");
                            break;
                        case 2:
                            Console.WriteLine("###\n# #\n # \n#\n###");
                            break;
                        case 3:
                            Console.WriteLine("###\n  #\n # \n  #\n###");
                            break;
                        case 4:
                            Console.WriteLine("# #\n# #\n###\n  #\n  #");
                            break;
                        case 5:
                            Console.WriteLine("###\n#\n###\n  #\n###");
                            break;
                        case 6:
                            Console.WriteLine("###\n#\n###\n# #\n###");
                            break;
                        case 7:
                            Console.WriteLine("###\n  #\n #\n#\n#");
                            break;
                        case 8:
                            Console.WriteLine("###\n# #\n # \n# #\n###");
                            break;
                        default:
                            Console.WriteLine("###\n# #\n###\n  #\n###");
                            break;
                    }
                }
                catch(Exception)
                {
                    Console.Clear();
                    
                 Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("ERROR");
                    Thread.Sleep(3000); 
                 Console.Clear();
                 Console.BackgroundColor = ConsoleColor.Black;
                }
            }
        }
    }
}
