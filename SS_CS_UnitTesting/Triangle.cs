namespace SS_CS_UnitTesting
{
    public class Triangle
    {
        private Point _a;
        private Point _b;
        private Point _c;

        public Triangle(Point a, Point b, Point c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double Perimetr()
        {
            var ab = _a.Distance(_b);
            var bc = _b.Distance(_c);
            var ac = _a.Distance(_c);

            return ab + bc + ac;
        }

        public double Area()
        {
            return 0.5 * Math.Abs(_a.X * (_b.Y - _c.Y) + _b.X * (_c.Y - _a.Y) + _c.X * (_a.Y - _b.Y));
        }

        public override string ToString()
        {
            return $"A: {_a}, B: {_b}, C: {_c}, has perimetr {Perimetr()} and area {Area()}";
        }

        public void Print()
        {
            Console.WriteLine(this);
        }

    }
}
