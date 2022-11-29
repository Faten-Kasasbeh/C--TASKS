using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        //practice
        abstract class Car
        {
            public abstract void StartEngine();
            public abstract void StopEngine();
            public abstract void OpenDoor();
            public abstract void CloseDoor();
            public abstract void Honk();
            public abstract void IncreaseSpeed();
            public abstract void DecreaseSpeed();
            public abstract void Breaks();
            public abstract void OpenWindow();
            public abstract void CloseWindow();
            public abstract void AdjustSeat();
            public abstract void CleanGlass();
            public abstract void ChangeGear();
        }
        class ford : Car
        {
            public override void StartEngine() {
                Console.WriteLine("StartEngine");
            }
            public override void StopEngine() {
                Console.WriteLine("StopEngine");
            }
            public override void OpenDoor() {
                 Console.WriteLine("OpenDoor");
            }
            public override void CloseDoor() {
                Console.WriteLine("CloseDoor");
            }
            public override void Honk() {
                Console.WriteLine("Honk");
            }
            public override void IncreaseSpeed() {
                Console.WriteLine("IncreaseSpeed");
            }
            public override void DecreaseSpeed() {
                Console.WriteLine("DecreaseSpeed");
            }
            public override void Breaks() {
                Console.WriteLine("Breaks");
            }
            public override void OpenWindow() {
                Console.WriteLine("OpenWindow");

            }
            public override void CloseWindow() {
                Console.WriteLine("CloseWindow");

            }
            public override void AdjustSeat() { 
                Console.WriteLine("AdjustSeat");
            }
            public override void CleanGlass()
            {
                Console.WriteLine("CleanGlass");
            }
            public override void ChangeGear()
            {
                Console.WriteLine("ChangeGear");
            }





        }
        static void Main(string[] args)
        {
            ford ford1= new ford();
            ford1.StartEngine();    
            ford1.StopEngine();
           ford1.OpenDoor();
        }
    }
}

