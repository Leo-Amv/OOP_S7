namespace OOP_S7
{
    public class Square : Rectangle
    {
        private double firstSide;
        public Square(double firstSide) : base(firstSide, firstSide)
        {
            this.firstSide = firstSide;
        }
        public override double Area()
        {
            return this.firstSide * this.firstSide;
        }
    }
}