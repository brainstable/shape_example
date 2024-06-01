
using ShapeManager;

Shape shape = new Circle(5);
Console.WriteLine($"{shape.Name}: {shape.GetArea()}");

shape = new Triangle(3, 4, 5);
Console.WriteLine($"{shape.Name}: {shape.GetArea()}");
