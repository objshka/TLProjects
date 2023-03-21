namespace Shop;

public class asd
{
    private List<Product> _products = new List<Product>();
    
    private void CreateAppliance()
    {
        Console.WriteLine("Какую технику вы хотите добавить: ");
        Console.WriteLine("1 - Телевизор LG \n2 - Кофемашину DeLonghi");
        string? userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                _products.Add(new Appliance(NamesOfProducts.TvLg, 10.0, 20000, 20, "Просмотр телевизионных программ"));
                break;
            case "2":
                _products.Add(new Appliance(NamesOfProducts.DelonghiCoffeeMachine, 5.0, 15000, 50, "Приготовление кофе"));
                break;
            default:
                Console.WriteLine("Такую модель мы не закупаем, она не рентабельна");
                break;
        }
    }
}