using Shop;

namespace ShopTests;

public class TestCreateDishes
{
    private List<Dishes> _products;

    [SetUp]
    public void Setup()
    {
        _products = new List<Dishes>();
    }

    [Test]
    public void CreateFurniture_AddsNewFurnitureToList()
    {
        // Arrange
        var input = "1";
        var dishes = new Dishes(NamesOfProducts.TableService, 1.0, 5000, "Керамика");
        var stringReader = new StringReader(input);
        Console.SetIn(stringReader);
        
        // Act
        CreateDishes();
        
        // Assert
        Assert.That(_products, Has.Count.EqualTo(1));
        Assert.That(_products, Has.Member(dishes));
    }
    
    private void CreateDishes()
    {
        Console.WriteLine("Какую посуду вы хотите добавить: ");
        Console.WriteLine("1 - Настольный сервис \n2 - Набор кастрюль");
        string? userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                _products.Add(new Dishes(NamesOfProducts.TableService, 1.0, 5000, "Керамика"));
                break;
            case "2":
                _products.Add(new Dishes(NamesOfProducts.SetOfPots, 3.0, 8000, "Алюминий"));
                break;
            default:
                Console.WriteLine("Такую модель мы не закупаем, она не рентабельна");
                break;
        }
    }
}