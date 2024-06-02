namespace ShapeManager;

public class Circle : Shape
{
    private readonly double r;

    public Circle(double r)
    {
        if (r <= 0)
            throw new ArgumentOutOfRangeException("Радиус круга не может быть меньше или равен нулю");
        
        this.r = r;
        Name = "Круг";
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(r, 2);
    }
}