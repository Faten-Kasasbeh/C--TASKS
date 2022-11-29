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
        abstract class car
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
        static void Main(string[] args)
        {
        }
    }
}
