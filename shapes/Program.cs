namespace shapes
{
    public class shapes
    {
        abstract class Shape<T>
{
    public abstract T CalculateSurfaceArea();
}

class Rectangle : Shape<double>
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double CalculateSurfaceArea()
    {
        return length * width;
    }
}

class Circle : Shape<double>
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateSurfaceArea()
    {
        return Math.PI * radius * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape<double> rectangle = new Rectangle(5.0, 3.0);
        Shape<double> circle = new Circle(2.5);

        Console.WriteLine("Rectangle surface area: " + rectangle.CalculateSurfaceArea());
        Console.WriteLine("Circle surface area: " + circle.CalculateSurfaceArea());
    }
}
    }
}