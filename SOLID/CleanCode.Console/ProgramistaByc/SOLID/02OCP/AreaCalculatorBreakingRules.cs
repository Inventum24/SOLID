using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Console.ProgramistaByc.SOLID._02OCP
{
    public static class AreaCalculatorBreakingRules
    {
        public static double CalculateRectanglesAreas(Rectangle[] rectangles)
        {
            double area = 0;
            foreach (var rectangle in rectangles)
                area += rectangle.Height * rectangle.Width;

            return area;
        }

        public static double CalculateTrianglesAreas(Triangle[] triangles)
        {
            double area = 0;
            foreach (var triangle in triangles)
                area += (triangle.Base * triangle.Height) / 2;

            return area;
        }

    }
}
