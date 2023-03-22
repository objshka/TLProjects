using Calculator;

namespace CalculatingTests;

public class Tests
{
    [Test]
    public void TestPolishNatation()
    {
        // Arrange
        var calculator = new Calculatoring();
        var input = "2 3 + 4 *";
        var expected = 20;

        using (var stringReader = new StringReader(input))
        {
            Console.SetIn(stringReader);

            // Act
            var result = calculator.PolishNatation();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
    
    [Test]
    public void TestClassicCalculator()
    {
        // Arrange
        var calculator = new Calculatoring();
        var input = "2\n+\n3\n";
        var expected = 5;

        using (var stringReader = new StringReader(input))
        {
            Console.SetIn(stringReader);

            // Act
            var result = Calculatoring.ClassicCalculator();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
