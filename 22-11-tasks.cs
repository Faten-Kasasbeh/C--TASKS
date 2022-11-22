using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _22_11_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

            //task2
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == "Tomato")
                {
                    Console.WriteLine("index of Tomato is :" + i);
                }
                if (fruits[i] == "Banana")
                {
                    Console.WriteLine("index of Banana is :" + i);
                }
            }

            //task3
            String[] foods = { "Meat", "Potato", "Mansaf", "Cake", "Sandwitch" };
            foreach (string x in foods)
            {
                Console.WriteLine("food: " + x);
            }
            String[] sport = { "Football", "Tinnes", "Golf" };
            foreach (string y in sport)
            {
                Console.WriteLine("sport: " + y);
            }
            String[] Movie = { "The Godfather ", "The Dark Knight", "The Matrix", "Se7en" };
            for (int w = 0; w < Movie.Length; w++)
            {
                Console.WriteLine("Movie: " + Movie[w]);
            }

            //task4
            Console.WriteLine("Please Input three numbers separated by comma");
            string number = Console.ReadLine();
            int sum = 0;
            string myInt = "";
            int my = 0;

            foreach (char ch in number)
            {
                if (ch.ToString() != ",")
                {
                    myInt += ch;
                }
                else
                {
                    my = int.Parse(myInt.ToString());
                    sum += my;
                    myInt = "";
                }
            }
            my = int.Parse(myInt.ToString());
            sum += my;
            Console.WriteLine(sum);


            //task5
            int sum1 = 0;
            Console.Write("The odd numbers are:");
            for (int f = 1; f <= 100; f++)
            {
                if (f % 2 != 0)
                {
                    Console.Write(f + " ,");
                    sum1 += f;
                }
            }
            Console.WriteLine("");
            Console.WriteLine(" The Sum of odd Numbers is:" + sum1);


            //task6
            for (int n = 1; n <= 4; n++)
            {
                for (int k = 5; k >= n; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }


            //task7
            int number1 = 1;
            for (int n = 1; n <= 4; n++)
            {
                for (int k = 5; k >= n; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(number1 + " ");
                    number1++;
                }

                Console.WriteLine();
            }

            //task8
            int sum2 = 0;
            int sum3 = 0;
            double avg = 0;
            string[] List1 = new string[] { };


            List1 = Console.ReadLine().Split(',');
            string[] List2 = List1;
            string [] List3 = { "0" };
            for (int i = 0; i < List1.Length; i++)
            {
                sum2+= int.Parse(List1[i]);
                for (int j = 0; j < List3.Length; j++)
                {
                    if (List1[i] != List3[j])
                    {
                        List3[j] = List1[i];
                        sum3 += int.Parse(List3[j]);
                    }
                }

            }
            avg = sum3 / List2.Length;
            Console.WriteLine("avarege = "+ avg);
        }
    }
}