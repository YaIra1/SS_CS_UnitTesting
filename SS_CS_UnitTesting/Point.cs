namespace SS_CS_UnitTesting
{
    public struct Point
    {
        private double _x;
        private double _y;

        public double X => _x;
        public double Y => _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double Distance(Point p)
        {
            double dX = p.X - _x;
            double dY = p.Y - _y;

            return Math.Sqrt(dX * dX + dY * dY);
        }

        public override string ToString()
        {
            return $"({_x},{_y})";
        }
    }
}
