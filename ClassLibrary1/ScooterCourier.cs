

public class ScooterCourier:DeliveryStaff
{
    private string _areaType;

    public string AreaType
    {
        set
        {
            _areaType = value;
        }

        get
        {
            return _areaType;
        }
    }

    public ScooterCourier(string staffId, string staffName, string location, string vehicleNumber,string areaType) : base(staffId, staffName, location, vehicleNumber)
    {
        AreaType = areaType;

    }

    public override string GetFuelAllowance()
    {
        return "Fuel Allowance: ₹800";
    }

    public override string GetVehicleType()
    {
        return "Vehicle is Scooter ";
    }

   public bool CanAccessNarrowLanes()
    {
        if(AreaType == "Urban" || AreaType == "urban")
        {
            return true;
        }

        else
        {
            return false;
        }
    }

}
