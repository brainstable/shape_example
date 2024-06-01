namespace ShapeManager;

public class Triangle : Shape
{
    private readonly double a;
    private readonly double b;
    private readonly double c;

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Ни одна сторона треугольника не может быть меньше или равна нулю");

        if (a >= b + c || b >= a + c || c >= a + b)
            throw new Exception("Треугольник с такими сторонами не существует");
        
        this.a = a;
        this.b = b;
        this.c = c;
        
        Name = IsIsosceles() ? "Прямоугольный треугольник" : "Треугольник";
    }

    public override double GetArea()
    {
        double p = a + b + c;

        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public bool IsIsosceles()
    {
        double tolerance = 0.001;
        
        double a2 = a * a;
        double b2 = b * b;
        double c2 = c * c;
        
        return (Math.Abs(a2 - (b2 + c2)) < tolerance) 
               || (Math.Abs(b2 - (a2 + c2)) < tolerance) 
               || (Math.Abs(c2 - (a2 + b2)) < tolerance);
    }
}