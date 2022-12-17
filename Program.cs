namespace OOP_S7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Triangle ta = new Triangle(10, 20, 20);
            Square sq = new Square(3);
            Rectangle ra = new Rectangle(4, 5);
            Circle cr = new Circle(6);
            FiguresRepository figuresRepository = new FiguresRepository();
            figuresRepository.Add(ta);
            figuresRepository.Add(sq);
            figuresRepository.Add(ra);
            figuresRepository.Add(cr);
            Console.WriteLine(string.Join("  ", figuresRepository.AllAreas()));
            Console.WriteLine(string.Join("  ", figuresRepository.AllPerimeters()));
            Console.WriteLine(string.Join("  ", figuresRepository.AllLengths()));
        }
    }
}
