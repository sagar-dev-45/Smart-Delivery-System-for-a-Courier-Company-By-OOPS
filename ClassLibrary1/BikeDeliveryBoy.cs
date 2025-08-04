


public class BikeDeliveryBoy:DeliveryStaff
{
    private int _deliveryCountPerDay;

    public int DeliveryCountPerDay
    {
        set
        {
            _deliveryCountPerDay = value;
        }

        get
        {
            return _deliveryCountPerDay;
        }
    }

    public BikeDeliveryBoy(string staffId, string staffName, string location, string vehicleNumber,int deliveryCountPerDay) : base(staffId, staffName,location,vehicleNumber)
    {
        DeliveryCountPerDay = deliveryCountPerDay;

    }

    public override string GetFuelAllowance()
    {
        return "Fuel Allowance: ₹500";
    }

    public override string GetVehicleType()
    {
        return "Vehicle is Bike ";
    }


    public int CalculateBonus()
    {
        if (DeliveryCountPerDay > 10) return 1000;
        else return 500;
    }
}

