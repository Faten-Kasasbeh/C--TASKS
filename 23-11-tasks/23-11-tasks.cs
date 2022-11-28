using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _23_11_tasks
{
    internal class Program
    {
        static void task1()
        {
            Console.WriteLine("Please enter 10 numbers");
            int sum = 0;
         for(int i=1; i<=10; i++) {
                int y = Int32.Parse(Console.ReadLine()) ;
                Console.WriteLine("number"+i +"=  "+y);
                sum+= y ;
            }
            Console.WriteLine("sum= " + sum);
               Console.WriteLine("avg= "+ sum/10);
        }
        static void task2()
        {
            Console.WriteLine("Please enter number");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("number is: "+y + "  and the cube is:" + y*y*y);
        }

        static void task3(int[] array )
        {
            foreach (int x in array)

            {
                if (x > 1950) Console.WriteLine("The year "+ x +" is greater than 1950");
            }

        }
        static int task4(int x) {
            Console.WriteLine("the age in years = " + x);
            return x * 365;
                }


        static int task5(int x, int y , int z) {
            int legs = x * 2 + y * 4 + z * 4;
            return legs;
        }

        static void task6()
        {
            string[] userName = { "Ahmad", "Ali", "Zayd" };
            string[] password = { "123456", "234567", "345678" };
            Console.WriteLine("please enter user name");
            string user = Console.ReadLine();
            Console.WriteLine("please enter password");
            string pass = Console.ReadLine();
          
                if ((user == userName[0] && pass == password[0])|| (user == userName[1] && pass == password[1])|| (user == userName[2] && pass == password[2]))
                {
                    Console.WriteLine(" pass");
                }
                else
                {
                Console.WriteLine("fail");
                }
               
            }

        
        static void task7()
        {
            Console.WriteLine("Please enter number");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("number is: " + y + "  and the power is:" + y * y);
        }
        static void task8()
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (Year <= 2024 && Year >= 1900)
            {
                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) Console.WriteLine("{0} is a Leap Year.", Year);
                else Console.WriteLine("{0} is not a Leap Year.", Year);
            }
        }


        static void task9 () {
            Console.WriteLine("please enter number");
            int num = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", num);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
         static void task10()
        {
            Console.WriteLine("PLEASE enter sentence");
            int num = 0;
            string sen = Console.ReadLine();
            foreach(char cha in sen)
            {
                if( cha.ToString() == " ") {
                num++;}
            }
            num++;
            Console.WriteLine("the number of words= " + num);
        }
        static void Main(string[] args)
        {

            task1();
            Console.WriteLine(".....................................");

            task2();
            Console.WriteLine(".....................................");

            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            task3(years);
            Console.WriteLine(".....................................");

            Console.WriteLine("please enter age");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("the age in days=  " + task4(y));
            Console.WriteLine(".....................................");


            Console.WriteLine("enter number of chickens ");
            int chickens = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter number of cows ");
            int cows = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter number of pigs ");
            int pigs = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The number of legs in farm =  " + task5(chickens, cows, pigs));

            task6();
            Console.WriteLine(".....................................");

            task7();
            Console.WriteLine(".....................................");

            task8();
            Console.WriteLine(".....................................");

            task9();
            Console.WriteLine(".....................................");

            task10();

        }

    }
} 
