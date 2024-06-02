using ShapeManager;

namespace TestShape;

[TestFixture]
public class TestShapeManager
{
    [TestCase(0)]
    [TestCase(-1)]
    public void ArgumentOutOfRangeException_WhenCreateCircle(double r)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(r));
    }
    
    [TestCase(0, 0, 0)]
    [TestCase(0, 1, 2)]
    [TestCase(1, 0, 2)]
    [TestCase(2, 1, 0)]
    [TestCase(-1, -1, -1)]
    [TestCase(-1, 1, 2)]
    [TestCase(1, -1, 2)]
    [TestCase(2, 1, -1)]
    public void ArgumentOutOfRangeException_WhenCreateTriangle(double a, double b, double c)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));
    }
    
    [TestCase(1, 2, 4)]
    [TestCase(1, 4, 8)]
    public void Exception_WhenCreateTriangle(double a, double b, double c)
    {
        Assert.Throws<Exception>(() => new Triangle(a, b, c));
    }

    [TestCase(3, 4, 5)]
    [TestCase(5, 12, 13)]
    [TestCase(8, 15, 17)]
    public void IsIsoscelesTriangle(double a, double b, double c)
    {
        Triangle triangle = new Triangle(a, b, c);
        
        Assert.That(triangle.IsIsosceles, Is.True);
    }
    
    [TestCase(6, 8, 9)]
    [TestCase(10, 15, 20)]
    public void IsNotIsoscelesTriangle(double a, double b, double c)
    {
        Triangle triangle = new Triangle(a, b, c);
        
        Assert.That(triangle.IsIsosceles, Is.False);
    }
}