namespace Shop;

public class Market
{
    private const string CommandShowProductsByType = "1";
    private const string CommandAddProduct = "2";
    private const string CommandExit = "3";
    private List<Product> _products = new List<Product>();

    public Market()
    {
        FillProducts();
    }

    public void Work()
    {
        bool isOpen = true;
        
        while (isOpen)
        {
            ShowCommands();
            string? userInput = Console.ReadLine();

            switch (userInput)
            {
                case CommandShowProductsByType:
                    ShowProductsByType();
                    break;
                case CommandAddProduct:
                    AddProduct();
                    break;
                case CommandExit:
                    isOpen = false;
                    break;
                default:
                    Console.WriteLine("К сожалению такой комманды нет, попробуйте указать " +
                                      "один из вариантов (1, 2, 3)");
                    break;
            }
            
            Console.ReadKey();
            Console.Clear();
        }
    }

    private void AddProduct()
    {
        Console.WriteLine("Какой тип продукта вы хотите добавить: ");

        string? userProduct = Console.ReadLine()?.ToLower();

        switch (userProduct)
        { 
            case "техника":
                CreateAppliance();
                break;
            case "посуда":
                CreateFurniture();
                break;
            case "мебель":
                CreateDishes();
                break;
            default:
                Console.WriteLine("К сожалению такой тип продуктов добавить нельзя");
                break;
        }
    }

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
    
    private void ShowProductsByType()
    {
        Console.Write("Какой тип товаров вам нужен, вы можете выбрать один из трех " +
                          "техника, мебель, посуда: ");
        string? userType = Console.ReadLine();
        var sortedProducts = _products.Where(product => product.GetProductType() == userType).ToList();

        if (sortedProducts.Count > 0)
        {
            List<Product> uniqueProducts = sortedProducts.GroupBy(product => product.Name)
                .Select(group => group.First()).ToList();

            foreach (var uniqueProduct in uniqueProducts)
            {
                int count = sortedProducts.Count(product => product.Name == uniqueProduct.Name);
                uniqueProduct.ShowInfo();
                Console.WriteLine("В магазине осталось - " + count + " штук");
            }
        }
        else
        {
            Console.WriteLine("К сожалению продуктов такого типа у нас нет");
        }
    }

    private void ShowCommands()
    {
        Console.WriteLine("Привет, вы пришли в магазин у вас есть такие коммнады:");
        Console.WriteLine(CommandShowProductsByType + " Укажите тип продукции которая вам нужна и вы увидите все продукты" +
                          "этого типа");
        Console.WriteLine(CommandAddProduct + " Добавить продукт");
        Console.WriteLine(CommandExit + " Закрыть приложение");
    }
    
    private void FillProducts()
    {
        int countPacks = 2;

        for (int i = 0; i < countPacks; i++)
        {
            _products.Add(new Appliance(NamesOfProducts.TvLg, 10.0, 20000, 20, "Просмотр телевизионных программ"));
            _products.Add(new Appliance(NamesOfProducts.DelonghiCoffeeMachine, 5.0, 15000, 50, "Приготовление кофе"));
            _products.Add(new Furniture(NamesOfProducts.CornerSofa, 50.0, 30000, "2x2 м", "Кожа"));
            _products.Add(new Furniture(NamesOfProducts.Wardrobe, 40.0, 25000, "2x1.5 м", "Дерево"));
            _products.Add(new Dishes(NamesOfProducts.TableService, 1.0, 5000, "Керамика"));
            _products.Add(new Dishes(NamesOfProducts.SetOfPots, 3.0, 8000, "Алюминий"));
        }
    }
}