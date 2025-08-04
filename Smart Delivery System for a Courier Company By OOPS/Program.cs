
/*Create a List<DeliveryStaff>

Add 2 objects of each type (Bike, Truck, Scooter) with meaningful data

Iterate the list and print:

Name, ID, Location, VehicleType

Call GetFuelAllowance() (polymorphic)

Call their specific method using is or pattern matching:*/

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

        BikeDeliveryBoy bikeDeliveryBoy = new BikeDeliveryBoy("B101", "Onkar Shinde", "Pune", "MH12-2002",20);


        TruckDriver truck = new TruckDriver("T201", "Pravin Bhosale", "Mumbai", "MH01-3456", 200);

        ScooterCourier scooterCourier = new ScooterCourier("S301", "manav patail", "Nashik", "MH3-2025", "Urban");


        Console.WriteLine("******** Printing Delivery Staff Details ********");

        Console.WriteLine("\n Details Of Bike Delivery Boy\n");
        Console.WriteLine  ("Staff Id : " + bikeDeliveryBoy.StaffId);
        Console.WriteLine("Staff Name : " + bikeDeliveryBoy.StaffName);
        Console.WriteLine("Location : "+bikeDeliveryBoy.Location);
        Console.WriteLine("Vehicle Number : "+bikeDeliveryBoy.VehicleNumber);
        Console.WriteLine("Delivery Count Per Day : " + bikeDeliveryBoy.DeliveryCountPerDay);
        Console.WriteLine("Fuel Allowance : "+bikeDeliveryBoy.GetFuelAllowance());
        Console.WriteLine("Vehicle Type : " + bikeDeliveryBoy.GetVehicleType());
        Console.WriteLine("Total Bonus : " + bikeDeliveryBoy.CalculateBonus());

        Console.WriteLine("\n Details Of Truck Delivery Boy\n");
        Console.WriteLine("Staff Id : " + truck.StaffId);
        Console.WriteLine("Staff Name : " + truck.StaffName);
        Console.WriteLine("Location : " + truck.Location);
        Console.WriteLine("Vehicle Number : " + truck.VehicleNumber);
        Console.WriteLine("Fuel Allowance : " + truck.GetFuelAllowance());
        Console.WriteLine("Vehicle Type : " + truck.GetVehicleType());
        Console.WriteLine("Type Of Licence : "+truck.GetLicenseCategory());


        Console.WriteLine("\n Details Of Scooter Delivery Boy\n");
        Console.WriteLine("Staff Id : " + scooterCourier.StaffId);
        Console.WriteLine("Staff Name : " + scooterCourier.StaffName);
        Console.WriteLine("Location : " + scooterCourier.Location);
        Console.WriteLine("Vehicle Number : " + scooterCourier.VehicleNumber);
        Console.WriteLine("Fuel Allowance : " + scooterCourier.GetFuelAllowance());
        Console.WriteLine("Vehicle Type : " + scooterCourier.GetVehicleType());
        Console.WriteLine("Can Access Narrow Lanes ? " + scooterCourier.CanAccessNarrowLanes());

        Console.ReadKey();
    }
   
}
