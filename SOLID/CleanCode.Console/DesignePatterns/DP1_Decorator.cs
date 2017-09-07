using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Console.DesignePatterns
{
    //Attach additional responsibilities to an object dynamically.
    //Decorators provide a flexible alternative to subclassing for extending functionality.

    //  The interface Coffee defines the functionality of Coffee implemented by decorator
    public interface ICoffee
    {

        double getCost();

        //  Returns the cost of the coffee
        String getIngredients();
    }
    //  Extension of a simple coffee without any extra ingredients
    public class SimpleCoffee : ICoffee
    {     
        public double getCost()
        {
            return 1;
        }

        public String getIngredients()
        {
            return "Coffee";
        }
    }

    //  Abstract decorator class - note that it implements Coffee interface
    public abstract class CoffeeDecorator : ICoffee
    {

        protected ICoffee decoratedCoffee;

        public CoffeeDecorator(ICoffee c)
        {
            this.decoratedCoffee = c;
        }

        public virtual double getCost()
        {
            //  Implementing methods of the interface
            return this.decoratedCoffee.getCost();
        }

        public virtual String getIngredients()
        {
            return this.decoratedCoffee.getIngredients();
        }
    }

    //  Decorator WithMilk mixes milk into coffee.
    //  Note it extends CoffeeDecorator.
    class WithMilk : CoffeeDecorator
    {

        public WithMilk(ICoffee c) :base(c)
        {

        }

        public override double getCost()
        {
            //  Overriding methods defined in the abstract superclass
            return (base.getCost() + 0.5);
        }

        public override String getIngredients()
        {
            return (base.getIngredients() + ", Milk");
        }
    }
    //  Decorator WithSprinkles mixes sprinkles onto coffee.
    //  Note it extends CoffeeDecorator.
    class WithSprinkles : CoffeeDecorator
    {

        public WithSprinkles(ICoffee c) :base(c){
        }

        public override double getCost()
        {
            return (base.getCost() + 0.2);
        }

        public override String getIngredients()
        {
            return (base.getIngredients() + ", Sprinkles");
        }
    }


}
