using ExAbstractizare.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IFigura> list = new List<IFigura>
       {
           new Linie(new Punct(45,45),new Punct(100,45),1000),
           new Cerc(25,new Punct(50,90),1001),
           new Dreptunghi(45,15,new Punct(50,70),1002),
           new Eticheta("text",50,40,new Punct(100,90),1003)
       };

        foreach (IFigura f in list)
        {
            f.Afisare();
            Console.WriteLine("\n");
        }

    }
}