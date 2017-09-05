using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Console.ProgramistaByc.SOLID._02OCP
{

public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
