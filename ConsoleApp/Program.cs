using FiguresLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вычисление площади фигуры без знания типа фигуры в compile-time, как я это понял
            Console.WriteLine("Enter figure type (circle/triangle):");
            string figureType = Console.ReadLine();
            IFigure figure = null;
            switch (figureType.ToLower())
            {
                case "circle":
                    Console.WriteLine("Enter circle radius:");
                    double radius = Double.Parse(Console.ReadLine());
                    figure = new Circle(radius);
                    break;
                case "triangle":
                    Console.WriteLine("Enter triangle side A:");
                    double sideA = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter triangle side B:");
                    double sideB = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter triangle side C:");
                    double sideC = Double.Parse(Console.ReadLine());
                    figure = new Triangle(sideA, sideB, sideC);
                    break;
                default:
                    Console.WriteLine("Unknown type of figure.");
                    break;
            }
            if (figure != null)
            {
                Console.WriteLine("Square of the {0} is {1}", figureType.ToLower(), figure.Square());
            }
            Console.ReadKey();
        }
    }
}