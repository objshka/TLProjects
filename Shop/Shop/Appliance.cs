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
}