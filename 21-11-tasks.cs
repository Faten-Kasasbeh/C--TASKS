using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine("Please enter tow int numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(y);
            }

            //task2

            Console.WriteLine("Please enter sign number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("the sign of number is: +");
            }
            else
            {
                Console.WriteLine("the sign of number is: -");
            }

            //task3

            Console.WriteLine("Please enter three int numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num1 + ", " + num2 + " ," + num3);
                }
                else
                {
                    Console.WriteLine(num1 + " ," + num3 + "," + num2);
                }
            }
            else if (num2 > num1 && num2 > num3)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num2 + ", " + num1 + " ," + num3);
                }
                else
                {
                    Console.WriteLine(num2 + " ," + num3 + "," + num1);
                }
            }
            else if (num3 > num1 && num3 > num2)
            {
                if (num1 > num2)
                {
                    Console.WriteLine(num3 + ", " + num1 + " ," + num2);
                }
                else
                {
                    Console.WriteLine(num2 + " ," + num2 + "," + num1);
                }
            }

            //task4
            Console.WriteLine("Please enter Five int numbers");
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());
            int num6 = Convert.ToInt32(Console.ReadLine());
            int num7 = Convert.ToInt32(Console.ReadLine());
            int num8 = Convert.ToInt32(Console.ReadLine());
            if (num4 > num5 && num4 > num6 && num4 > num7 && num4 > num8)
            {
                Console.WriteLine("The max number is :" + num4);
            }
            else if (num5 > num4 && num5 > num6 && num5 > num7 && num5 > num8)
            {
                Console.WriteLine("The max number is :" + num5);
            }
            else if (num6 > num4 && num6 > num5 && num6 > num7 && num6 > num8)
            {
                Console.WriteLine("The max number is :" + num6);
            }
            else if (num7 > num4 && num7 > num5 && num7 > num6 && num7 > num8)
            {
                Console.WriteLine("The max number is :" + num7);
            }
            else if (num8 > num4 && num8 > num5 && num8 > num6 && num8 > num7)
            {
                Console.WriteLine("The max number is :" + num8);
            }

            //task5
            Console.WriteLine("Please enter Velocity  in kelometter");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input kilometers per hour:" + v);
            double v1 = v * 0.62137119;
            Console.WriteLine(v1 + "miles per hour");

            //task6

            Console.WriteLine("Please enter hours ans minutes");
            int hours = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            int hours1 = hours * 60;
            int sum = hours1 + min;
            Console.WriteLine("Input hours: " + hours);
            Console.WriteLine("Input minutes: " + min);
            Console.WriteLine("Total: " + sum);

            //task7
            Console.WriteLine("Please enter time in minutes");
            int min1 = Convert.ToInt32(Console.ReadLine());
            int h1 = min1 / 60;
            int min2 = min1 % 60;
            Console.WriteLine("Input minutes :" + min1);
            Console.WriteLine(h1 + "hours ," + min2 + "minuites");

            //task8
            string[] names = { "Faten kasasbeh", "Lama ahmad", "Bana hamzh", "Lujain ali", "Salma mohammad" };
            Console.WriteLine(names[0].Substring(0, 6));
            Console.WriteLine(names[1].Substring(0, 6));
            Console.WriteLine(names[2].Substring(0, 6));
            Console.WriteLine(names[3].Substring(0, 6));
            Console.WriteLine(names[4].Substring(0, 6));
        }
    }
}
