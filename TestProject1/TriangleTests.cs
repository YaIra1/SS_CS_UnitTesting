using SS_CS_UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(0, 4, 3, 0, 0, 0, 12)] 
        [InlineData(0, 0, -3, 0, -6, 0, 12)]
        [InlineData(0, 0, 0, 0, 0, 0, 0)]
        public void Perimetr_Should_Return_Value(double x1, double y1, double x2, double y2, double x3, double y3, double expectedPerim)
        {
            var p1 = new Point(x1, y1);
            var p2 = new Point(x2, y2);
            var p3 = new Point(x3, y3);

            var triangle = new Triangle(p1, p2, p3);
            var perim = triangle.Perimetr();

            Assert.Equal(expectedPerim, perim);

        }

        [Theory]
        [InlineData(0, 4, 3, 0, 0, 0, 6)]
        [InlineData(0, 0, -3, 0, -6, 0, 0)]
        [InlineData(0, 0, 0, 0, 0, 0, 0)]
        public void Area_Should_Return_Value(double x1, double y1, double x2, double y2, double x3, double y3, double expectedArea)
        {
            var p1 = new Point(x1, y1);
            var p2 = new Point(x2, y2);
            var p3 = new Point(x3, y3);

            var triangle = new Triangle(p1, p2, p3);
            var area = triangle.Area();

            Assert.Equal(expectedArea, area);

        }

    }
}
