using Abstractizare.Interface;

internal class Program
{
    private static void Main(string[] args)
    {

        List<IShape> shapes = new List<IShape>
        {
            new Circle(5),
            new Triangle(4, 5)
        };

        foreach (IShape shape in shapes)
        {
            shape.Display();
            Console.WriteLine($"Area: {shape.CalculateArea()}");
        }

    }
}