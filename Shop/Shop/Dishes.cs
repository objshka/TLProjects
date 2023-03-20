namespace Shop;

public class Dishes : Product
{
    public Dishes(NamesOfProducts name, double weight, int price, string material) : base(name, weight, price)
    {
        Material = material;
        Description = SetDescription();
    }
    
    public string Material { get; private set; }
    
    public sealed override string SetDescription()
    {
        return $"Material {Material}";
    }

    public override string GetProductType()
    {
        return "посуда";
    }
}