namespace OOP_S7
{
    public class Circle : Figure, ILengthable
    {
        private const double pi = 3.14;
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return pi * radius * radius;
        }
        public double Length()
        {
            return pi * radius * 2;
        }
    }
}