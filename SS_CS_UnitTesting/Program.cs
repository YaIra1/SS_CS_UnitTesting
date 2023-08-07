namespace SS_CS_UnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> list = new List<Triangle>()
            {
                new Triangle(new Point(3,2), new Point(6,4), new Point(5,6)),
                new Triangle(new Point(-1,2), new Point(-8,4), new Point(-5,6)),
                new Triangle(new Point(1,-9), new Point(3,-4), new Point(4,-6)),
            };

            foreach (Triangle triangle in list)
            {
                triangle.Print();
            }
        }
    }
}