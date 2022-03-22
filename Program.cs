using System;

namespace Taxi
{
    static class Program
    {
        private static void Main(string[] args)
        {
            //membuat objek taxi
            Taxi taxi = new Taxi();

            //pengesetan nilai properties
            taxi.DriverName = "MEKEL";
            taxi.OnDuty = true;
            taxi.NumPassenger = 5;

            //pemanggilan method
            taxi.TaxiInfo();
            Console.WriteLine();
            taxi.PickupPassenger();
            taxi.DropOffPassenger();
            
            Console.ReadKey();
        }
    }
}


