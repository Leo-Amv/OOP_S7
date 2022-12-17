namespace OOP_S7
{
    public class Rectangle : Polygon
    {
        private double firstSide;
        private double secondSide;
        public Rectangle(double firstSide, double secondSide) : base(new List<double> { firstSide, secondSide, firstSide, secondSide })
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
        }
        public override double Area()
        {
            return this.firstSide * this.secondSide;
        }
    }
}