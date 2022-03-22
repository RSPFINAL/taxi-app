using System;

namespace Taxi
{
    public class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine($"Driver Name: {DriverName}");
            Console.WriteLine($"On Duty: {(OnDuty ? "Yes" : "No")}");
            Console.WriteLine($"Number of Passenger: {NumPassenger}");
        }
        public void PickupPassenger()
        {
            Console.WriteLine($"{DriverName} sedang dalam perjalanan menjemput penumpang");
        }
        public void DropOffPassenger()
        {
            Console.WriteLine($"{DriverName} driver selesai mengantar penumpang sampai tujuan");
        }
    }
}