using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Console.ProgramistaByc.SOLID._03LSP
{
    public class ElectricCar : Vehicle
    {
        public ElectricCar(int batteriesCount, int combusion, string name, int wheelsCount) :
            base(combusion, name, wheelsCount)
        {
            BatteriesCount = batteriesCount;
        }

        public int BatteriesCount { get; set; }

        public override void About()
        {
            System.Console.WriteLine($"I'm  <ELECTRIC_CAR> - {Name} - with {Combustion}L combustion, {WheelsCount} wheels and {BatteriesCount} batteries!");
        }
        public void ShowInfoAboutVehicle(Vehicle vehicle)
        {
            vehicle.About();
        }
    }
}
