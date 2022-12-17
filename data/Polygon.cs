namespace OOP_S7
{
    public abstract class Polygon : Figure, IPerimeterable
    {
        protected List<double> sides;
        public Polygon(List<double> sides)
        {
            this.sides = sides;
        }
        public double Perimeter()
        {
            double perimeter = 0;
            foreach (double side in sides)
            {
                perimeter += side;
            }
            return perimeter;
        }
    }
}