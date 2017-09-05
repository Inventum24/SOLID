using CleanCode.Console.ProgramistaByc.SOLID._03LSP;
using CleanCode.Console.ProgramistaByc.SOLID._04ISP;
using CleanCode.Console.CSharpHandbook._03Usage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //LSP();
            ISP();

            Enums.TestEnums();

            System.Console.ReadKey();
        }

        private static void ISP()
        {
            var electricCar = new ElectricCarIF();
            var car = new CarIF();

            car.Name = "Tesla";
            car.WheelsCount = 4;
            car.Type = "Muscle Car";
            car.Combustion = 10.5f;

            electricCar.Name = "Tesla";
            electricCar.WheelsCount = 4;
            electricCar.BatteriesCount = 10;

            electricCar.About();
            car.About();

            IVehicle ec = (IVehicle)electricCar;


        }

        private static void LSP()
        {
            ElectricCar elCar = new ElectricCar(10, -100, "The Best Electric Car", 4);
            elCar.ShowInfoAboutVehicle(elCar);
        }
    }
}
