﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _28_11_tasks
{

    public class Employee
    {
        protected string Name;
        protected int BIRTH;
        protected int ID;
      
        public Employee() { }
        public Employee(string name, int birth, int id)
        {
            Name = name;
           BIRTH= birth;
            ID = id;
        }

      public  virtual void welcome()
        {
            Console.WriteLine("wel");
        }
        
    }

    class Manager : Employee
    {
        public Manager(string name, int birth, int id) : base(name, birth, id)
        {

        }
        public override void welcome()
        {
            Console.WriteLine("welcome to Manager");
        }

        public void print() {
           int x= DateTime.Now.Year;
            int Age = (x - BIRTH);
            Console.WriteLine("Name is :  "+Name + " ,  Ige is :   " + Age + "  , ID of employee  " + ID ); }
    }

   
    internal class Program
    {


        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2000, 10, 2);
            int d= dateTime.Year;
            Manager employee1 = new Manager("AHMAD",d ,20012485);
            employee1.welcome();  
            employee1.print();

            Console.WriteLine("Please enter employee name ");
            string _name= Console.ReadLine();
            Console.WriteLine("Please enter employee birth ");
            string date1 =Console.ReadLine();
            DateTime date2 = Convert.ToDateTime(date1);
            int _birth = date2.Year;

            Console.WriteLine("Please enter employee id ");
            int _id =Convert.ToInt32(Console.ReadLine());

            Manager employee2 = new Manager(_name, _birth, _id);  
            employee2.welcome();
            employee2.print();

        }
    }
}


