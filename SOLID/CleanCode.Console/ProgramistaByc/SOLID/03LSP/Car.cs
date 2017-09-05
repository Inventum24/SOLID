using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Console.ProgramistaByc.SOLID._03LSP
{
    public class Car : Vehicle
    {
        public Car(string type, int combusion, string name, int wheelsCount) :
            base(combusion, name, wheelsCount)
        {
            Type = type;
        }

        public string Type { get; set; }

        public override void About()
        {
            System.Console.WriteLine($"I'm {Type} <CAR> - {Name} - with {Combustion}L combustion and {WheelsCount} wheels!");
        }
    }
}
