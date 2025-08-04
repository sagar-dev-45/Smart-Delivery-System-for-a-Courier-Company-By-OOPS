

public abstract class DeliveryStaff
{
    //Private Fields

    private string _staffId;
    private string _staffName;
    private string _location;
    private string _vehicleNumber;

    //Properties

    public string StaffId
    {
        set
        {
            _staffId = value;
        }

        get
        {
            return _staffId;
        }
    }

    public string StaffName
    {
        set
        {
            _staffName = value;
        }

        get
        {
            return _staffName;
        }
    }

    public string Location
    {
        set
        {
            _location = value;
        }

        get
        {
            return _location;
        }
    }

    public string VehicleNumber
    {
        set
        {
            _vehicleNumber = value;
        }
        get
        {
            return _vehicleNumber;
        }
    }

    //Constructor

    public DeliveryStaff(string staffId,string staffName,string location,string vehicleNumber)
    {
        StaffId = staffId;
        StaffName = staffName;
        Location = location;
        VehicleNumber = vehicleNumber;
    }

    public abstract string GetFuelAllowance();


    public virtual string GetVehicleType()
    {
        return "General Vehicle";
    }



}
