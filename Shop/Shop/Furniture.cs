namespace Shop;

public class Furniture : Product
{
    public Furniture(NamesOfProducts name, double weight, int price, string size, string materials) : base(name, weight, price)
    { 
        Size = size;
        Materials = materials;
        Description = SetDescription();
    }
    
    public string Size { get; private set; }
    public string Materials { get; private set; }
    
    public sealed override string SetDescription()
    {
        return $"Size {Size} Material {Materials}";
    }

    public override string GetProductType()
    {
        return "мебель";
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Price, Materials, Description, Size);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Furniture furniture = (Furniture)obj;
        return Name == furniture.Name && Price == furniture.Price && Materials == furniture.Materials && Description == furniture.Description && Size == furniture.Size;
    }
}