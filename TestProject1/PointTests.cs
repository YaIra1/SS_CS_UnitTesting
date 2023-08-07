using SS_CS_UnitTesting;

namespace UnitTests
{
    public class PointTests
    {
        [Theory]
        [InlineData(3,3,3,4,1)] // x1=3, y1=3, x2=3, y2=4, dist=1
        [InlineData(2,2,2,2,0)] 
        [InlineData(0,0,9,0,9)]
        public void Distance_Should_Return_Value(double x1, double y1, double x2, double y2, double expectedDist)
        {
            var p1 = new Point(x1, y1);
            var p2 = new Point(x2, y2);

            var dist = p1.Distance(p2);

            Assert.Equal(expectedDist, dist);
        }
    }
}