namespace ShapeManager;

public abstract class Shape
{
    public string Name { get; protected init; }
    public abstract double GetArea();

    public override string ToString()
    {
        return Name;
    }
}