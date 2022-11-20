using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_11_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine("Enter your name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Name is: " + Name);

            //task2
            int X = 10;
            double Y = 3.5;
            char Z = 'F';
            string name = "faten";
            bool result = false;
            const int number = 0787437374;
            Console.WriteLine(X);
            Console.WriteLine(Y);
            Console.WriteLine(Z);
            Console.WriteLine(name);
            Console.WriteLine(result);
            Console.WriteLine(number);

            //task3
            string[] cars = { "PEJO", "HYUNDAI", "BMW", "KIA" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);

            //task4
            Console.WriteLine("Input Your First Name :");
           string Firstname= Console.ReadLine();
            Console.WriteLine("Input Your last Name :");
            string Lastname = Console.ReadLine();
            Console.WriteLine("Input Your Birthday:");
            string birthday = Console.ReadLine();
            Console.WriteLine(Firstname+ " " + Lastname  +"  "+ birthday);

            //task5
            int[] TestData = { 10, 20, 30, 40, 50, 60, 70, 80, 90,100 };
            Console.WriteLine(TestData[0]);
            Console.WriteLine(TestData[1]);
            Console.WriteLine(TestData[2]);
            Console.WriteLine(TestData[3]);
            Console.WriteLine(TestData[4]);
            Console.WriteLine(TestData[5]);
            Console.WriteLine(TestData[6]);
            Console.WriteLine(TestData[7]);
            Console.WriteLine(TestData[8]);
            Console.WriteLine(TestData[9]);


            //task6
            int[] sum = { 8, 2, 5 };
            Console.WriteLine("Sum of all elements stored in the array is :");
          int sumation=  sum[0] + sum[1] + sum[2];
            Console.WriteLine(sumation);




        }
    }
}
