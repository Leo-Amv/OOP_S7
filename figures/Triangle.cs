namespace OOP_S7
{
    public class Triangle : Polygon
    {
        private double firstSide;
        private double secondSide;
        private double thirdSide;
        public Triangle(double firstSide, double secondSide, double thirdSide) : base(new List<double> { firstSide, secondSide, thirdSide })
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }
        public override double Area()
        {
            double p = base.Perimeter() / 2;
            return Math.Sqrt(p * (p - this.firstSide) * (p - this.secondSide) * (p - this.thirdSide));
        }
    }
}