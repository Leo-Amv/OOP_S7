namespace OOP_S7
{
    public class FiguresRepository : IRepository<Figure>
    {
        private List<Figure> figures;
        public FiguresRepository()
        {
            this.figures = new List<Figure>();
        }
        public void Add(Figure figure) => this.figures.Add(figure);
        public List<double> AllPerimeters()
        {
            List<double> result = new List<double>();
            foreach (Figure figure in figures)
            {
                if (figure is IPerimeterable)
                {
                    result.Add(Math.Round(((IPerimeterable)figure).Perimeter(), 3));
                }
            }
            return result;
        }
        public List<double> AllLengths()
        {
            List<double> result = new List<double>();
            foreach (Figure figure in figures)
            {
                if (figure is ILengthable)
                {
                    result.Add(Math.Round(((ILengthable)figure).Length(), 3));
                }
            }
            return result;
        }
        public List<double> AllAreas()
        {
            List<double> result = new List<double>();
            foreach (Figure figure in figures)
            {

                result.Add(Math.Round(figure.Area(), 3));
            }
            return result;
        }
    }
}