namespace Shop;

public class Appliance : Product
{
    public Appliance(NamesOfProducts name, double weight, int price, double powerConsumption, string mainFunction) : base(name, weight, price)
    {
        PowerConsumption = powerConsumption;
        MainFunction = mainFunction;
        Description = SetDescription();
    }

    public double PowerConsumption { get; private set; }
    public string MainFunction { get; private set; }

    public sealed override string SetDescription()
    {
        return "Main function " + MainFunction + " power consumption " + PowerConsumption;
    }

    public override string GetProductType()
    {
        return "техника";
    }
    
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Appliance other = (Appliance)obj;
        return Name == other.Name &&
               Price == other.Price &&
               PowerConsumption == other.PowerConsumption &&
               Description == other.Description &&
               MainFunction == other.MainFunction;
    }

    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 23 + Name.GetHashCode();
        hash = hash * 23 + Price.GetHashCode();
        hash = hash * 23 + PowerConsumption.GetHashCode();
        hash = hash * 23 + Description.GetHashCode();
        hash = hash * 23 + MainFunction.GetHashCode();
        return hash;
    }
}