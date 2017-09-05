using System;

namespace CleanCode.Console.ProgramistaByc.SOLID._02OCP
{
    public class Triangle : Shape
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public override double CalculateArea()
        {
            return 0.0;
        }
    }
}