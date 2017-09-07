using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Console.DesignePatterns
{
    //Define a family of algorithms, encapsulate each one, and make them interchangeable. 
    //Strategy lets the algorithm vary independently from clients that use it.
    class Customer
    {

        private List<Double> drinks;

        private BillingStrategy strategy;

        public Customer(BillingStrategy strategy)
        {
            this.drinks = new List<Double>();
            this.strategy = strategy;
        }

        public void add(double price, int quantity)
        {
            this.drinks.Add(this.strategy.GetActPrice((price * quantity)));
        }

        //  Payment of bill
        public void printBill()
        {
            double sum = 0;
            foreach (Double i in this.drinks)
            {
                sum = (sum + i);
            }

            Debug.WriteLine(("Total due: " + sum));
            this.drinks.Clear();
        }

        //  Set Strategy
        public void setStrategy(BillingStrategy strategy)
        {
            this.strategy = strategy;
        }
    }
    interface BillingStrategy
    {
         double GetActPrice(double rawPrice);
    }
    //  Normal billing strategy (unchanged price)
    class NormalStrategy : BillingStrategy
    {
        public double GetActPrice(double rawPrice)
        {
            return rawPrice;
        }
    }
    //  Strategy for Happy hour (50% discount)
    class HappyHourStrategy : BillingStrategy
    {       
        public  double GetActPrice(double rawPrice)
        {
            return (rawPrice * 0.5);
        }
    }
}
