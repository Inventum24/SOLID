using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Console.ProgramistaByc.SOLID._03LSP
{
    public abstract class Vehicle
    {
        protected Vehicle(int combusion, string name, int wheelsCount)
        {
            Combustion = combusion;
            Name = name;
            WheelsCount = wheelsCount;
        }

        public int Combustion { get; set; }
        public string Name { get; set; }
        public int WheelsCount { get; }

        public virtual void About()
        {
            System.Console.WriteLine("I'm ABSTRACT!");
        }
    }
}
