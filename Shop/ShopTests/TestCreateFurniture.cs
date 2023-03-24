using Shop;

namespace ShopTests;

public class TestCreateFurniture
{
    private List<Furniture> _products;

    [SetUp]
    public void Setup()
    {
        _products = new List<Furniture>();
    }

    [Test]
    public void CreateFurniture_AddsNewFurnitureToList()
    {
        // Arrange
        var input = "1";
        var furniture = new Furniture(NamesOfProducts.CornerSofa, 50.0, 30000, "2x2 м", "Кожа");
        var stringReader = new StringReader(input);
        Console.SetIn(stringReader);
        
        // Act
        CreateFurniture();
        
        // Assert
        Assert.That(_products, Has.Count.EqualTo(1));
        Assert.That(_products, Has.Member(furniture));
    }
    
    private void CreateFurniture()
    {
        Console.WriteLine("Какую мебель вы хотите добавить: ");
        Console.WriteLine("1 - Угловой диван \n2 - Гардероб");
        string? userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                _products.Add(new Furniture(NamesOfProducts.CornerSofa, 50.0, 30000, "2x2 м", "Кожа"));
                break;
            case "2":
                _products.Add(new Furniture(NamesOfProducts.Wardrobe, 40.0, 25000, "2x1.5 м", "Дерево"));
                break;
            default:
                Console.WriteLine("Такую модель мы не закупаем, она не рентабельна");
                break;
        }
    }
}