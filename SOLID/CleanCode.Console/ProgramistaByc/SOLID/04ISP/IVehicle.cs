using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Console.ProgramistaByc.SOLID._04ISP
{
    public interface IVehicle
    {
        string Name { get; set; }
        int WheelsCount { get; set; }
        void About();
    }

    public interface IElectricVehicle : IVehicle
    {
        int BatteriesCount { get; set; }
    }

    public class CarIF : IVehicle
    {
        public string Type { get; set; }
        public double Combustion { get; set; }
        public string Name { get; set; }
        public int WheelsCount { get; set; }

        public void About()
        {
            System.Console.WriteLine($"I'm {Type} - {Name} - with {Combustion}L combustion and {WheelsCount} wheels count!");
        }
    }

    public class ElectricCarIF : IElectricVehicle
    {
        public string Name { get; set; }
        public int WheelsCount { get; set; }
        public int BatteriesCount { get; set; }

        public void About()
        {
            System.Console.WriteLine($"I'm  {Name} - with {WheelsCount} wheels count and {BatteriesCount} batteries count!");
        }

    }
}
