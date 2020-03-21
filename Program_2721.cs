using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TugasClassDanObject //havid pradipta husada //19.11.2721
{
    class Program
    {
        static void Main(string[] args)
{
Taxi taxi = new Taxi();
taxi.driverName = "Joni";
taxi.onDuty = true;
taxi.NumPassenger = 10;

taxi.TaxiInfo();
Console.WriteLine("\n");
taxi.PickUpPassenger();
taxi.DropOffPassenger();
Console.ReadKey();
}
    }
    class Taxi
{
    public string driverName { get; set; }
    public bool onDuty { get; set; }
    public int NumPassenger { get; set; }
    public void TaxiInfo()
    {
        Console.WriteLine("Driver Name          : {0}", driverName);
        if (onDuty)
        {
            Console.WriteLine("On Duty              : Yes");
        }
        else
        {
            Console.WriteLine("On Duty              : No");
        }
        Console.WriteLine("Number of Passenger  : {0}", NumPassenger);
    }
    public void PickUpPassenger()
    {
        if (onDuty)
        {
            Console.WriteLine("Driver {0} Sedang Menjemput Penumpang", driverName);
        }
        else
        {
            Console.WriteLine("Driver {0} Tidak Menjemput Penumpang", driverName);
        }
    }
    public void DropOffPassenger()
    {
        if (onDuty)
        {
            Console.WriteLine("Driver {0} Selesai Mengantar Penumpang", driverName);
        }
        else
        {
            Console.WriteLine("Driver {0} ", driverName);
        }
    }
}
}