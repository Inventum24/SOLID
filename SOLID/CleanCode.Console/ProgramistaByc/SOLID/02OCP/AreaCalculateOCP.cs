using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Console.ProgramistaByc.SOLID._02OCP
{
    public static class AreaCalculator
    {
        public static double CalculateArea(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
                area += shape.CalculateArea();

            return area;
        }
    }
}
