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
    
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Price, Material, Description);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Dishes dishes = (Dishes)obj;
        return Name == dishes.Name && Price == dishes.Price && Material == dishes.Material && Description == dishes.Description;
    }
}