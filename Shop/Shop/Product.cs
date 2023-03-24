namespace Shop;

public abstract class Product
{
    private static int _nextId = 1;
    
    public Product(NamesOfProducts name, double weight, int price)
    {
        Id = _nextId;
        _nextId++;
        Name = name;
        Weight = weight;
        Price = price;
    }

    public string Description { get; protected set; } = "";
    public int Id { get; } 
    public NamesOfProducts Name { get; } 
    public double Weight { get; }
    public int Price { get; }

    public void ShowInfo()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Weight: {Weight}, Cost: {Price}, Description: {Description}");
    }
    public abstract string SetDescription();
    public abstract string GetProductType();
}