using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _28_11_tasks
{

    public class car
    {
        protected string CarsMake;
        protected int YEAR;
        protected string TYPE;
        protected int PRICE;
        protected string MODEL;
        protected int PALLET;
        protected string COLOR;
        public car() { }
        public car(string carsMAke, int year, string type, int price, string model, int pallet, string color)
        {
            CarsMake = carsMAke;
            YEAR = year;
            TYPE = type;
            PRICE = price;
            MODEL = model;
            PALLET = pallet;
            COLOR = color;
        }

        public void STOP()
        {
            Console.WriteLine("STOP");
        }
        public void start()
        {
            Console.WriteLine("START");
        }
    }

     class Ford:car
    {
        public Ford(string carsMAke, int year, string type, int price, string model, int pallet, string color) : base (carsMAke,  year, type,  price,  model, pallet,  color)
        {
            //CarsMake = car;
            //YEAR = yearS;
            //TYPE = typeS;
            //PRICE = priceS;
            //MODEL = modelS;
            //PALLET = palletS;
            //COLOR = colorS;

        }
        public void print() { Console.WriteLine(CarsMake +" "+ YEAR +"  "+ TYPE +"  "+ PRICE +"  "+ MODEL +"  "+ PALLET +"  "+ COLOR); }
    }
    internal class Program
    {
      

        static void Main(string[] args)
            {
            Ford ford1 = new Ford("Itally", 2015, "Ford", 10000, "Fusion", 997584, "Black");
            ford1.print();
            ford1.start();  
            ford1.STOP();
            }
    }
}


