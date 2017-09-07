using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Console.DesignePatterns
{
    //Take into account also SOLID.OCP.Refactored Client !!!
    interface CarElement
    {
        void accept(CarElementVisitor visitor);
    }
    interface CarElementVisitor
    {
        void visit(Body body);

        void visit(Car car);

        void visit(Engine engine);

        void visit(Wheel wheel);
    }
    class Body : CarElement
    {

        public void accept(CarElementVisitor visitor)
        {
            visitor.visit(this);
        }
    }
    class Car : CarElement
    {

        CarElement[] elements;

        public Car()
        {
            this.elements = new CarElement[] {
                new Wheel("front left"),
                new Wheel("front right"),
                new Wheel("back left"),
                new Wheel("back right"),
                new Body(),
                new Engine()};
        }

        public void accept(CarElementVisitor visitor)
        {
            foreach (CarElement elem in this.elements)
            {
                elem.accept(visitor);
            }

            visitor.visit(this);
        }
    }
    class Engine : CarElement
    {

        public void accept(CarElementVisitor visitor)
        {
            visitor.visit(this);
        }
    }
    class Wheel : CarElement
    {

        private String name;

        public Wheel(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }

        public void accept(CarElementVisitor visitor)
        {
            visitor.visit(this);
        }
    }
    class CarElementDoVisitor : CarElementVisitor
    {

        public void visit(Body body)
        {
            Debug.WriteLine("Moving my body");
        }

        public void visit(Car car)
        {
            Debug.WriteLine("Starting my car");
        }

        public void visit(Wheel wheel)
        {
            Debug.WriteLine(("Kicking my "
                            + (wheel.getName() + " wheel")));
        }

        public void visit(Engine engine)
        {
            Debug.WriteLine("Starting my engine");
        }
    }
    class CarElementPrintVisitor : CarElementVisitor
    {

        public void visit(Body body)
        {
            Debug.WriteLine("Visiting body");
        }

        public void visit(Car car)
        {
            Debug.WriteLine("Visiting car");
        }

        public void visit(Engine engine)
        {
            Debug.WriteLine("Visiting engine");
        }

        public void visit(Wheel wheel)
        {
            Debug.WriteLine("Visiting "
                            + (wheel.getName() + " wheel"));
        }
    }
    public class VisitorDemo
    {

        public static void main(String[] args)
        {
            Car car = new Car();
            car.accept(new CarElementPrintVisitor());
            car.accept(new CarElementDoVisitor());
        }
    }
}
