

public class TruckDriver:DeliveryStaff
{


    private double _maxLoadCapacity;

    public double MaxLoadCapacity
    {
        set
        {
            _maxLoadCapacity = value;
        }

        get
        {
            return _maxLoadCapacity;
        }
    }

    public TruckDriver(string staffId, string staffName, string location, string vehicleNumber, double maxLoadCapacity) : base(staffId, staffName, location, vehicleNumber)
    {
        MaxLoadCapacity = maxLoadCapacity;

    }

    public override string GetFuelAllowance()
    {
        return "Fuel Allowance: ₹1500";
    }

    public override string GetVehicleType()
    {
        return "Vehicle is Truck ";
    }

    public string GetLicenseCategory()
    {
        return "Heavy Vehicle License";
    }

}
