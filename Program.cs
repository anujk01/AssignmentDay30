
using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            RideRepository invoiceGenerator = new RideRepository(RideType.NORMAL);

            double fare = invoiceGenerator.AddRide();
            Console.WriteLine(fare);
        }
    }
}
