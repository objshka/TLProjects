using Shop;

namespace ShopTests
{
    public class Tests
    {
        private List<Appliance> _products;

        [SetUp]
        public void Setup()
        {
            _products = new List<Appliance>();
        }

        [Test]
        public void CreateAppliance_AddsNewApplianceToList()
        {
            // Arrange
            var input = "1";
            var appliance = new Appliance(NamesOfProducts.TvLg, 10.0, 20000, 20, "Просмотр телевизионных программ");
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            // Act
            CreateAppliance();

            // Assert
            Assert.That(_products, Has.Count.EqualTo(1));
            Assert.That(_products, Has.Member(appliance));
        }

        [Test]
        public void CreateAppliance_WhenInvalidInputEntered_ShouldNotAddApplianceToList()
        {
            // Arrange
            var invalidInput = "3";
            var stringReader = new StringReader(invalidInput);
            Console.SetIn(stringReader);

            // Act
            CreateAppliance();

            // Assert
            Assert.That(_products, Has.Count.EqualTo(0));
        }

        private void CreateAppliance()
        {
            Console.WriteLine("Какую технику вы хотите добавить: ");
            Console.WriteLine("1 - Телевизор LG \n2 - Кофемашину DeLonghi");
            string? userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    _products.Add(new Appliance(NamesOfProducts.TvLg, 10.0, 20000, 20,
                        "Просмотр телевизионных программ"));
                    break;
                case "2":
                    _products.Add(new Appliance(NamesOfProducts.DelonghiCoffeeMachine, 5.0, 15000, 50,
                        "Приготовление кофе"));
                    break;
                default:
                    Console.WriteLine("Такую модель мы не закупаем, она не рентабельна");
                    break;
            }
        }
    }
}
