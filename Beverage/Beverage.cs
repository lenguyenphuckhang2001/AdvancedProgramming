using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage
{
    public abstract class Beverage
    {
        protected string description = "Unknow Beverage";
        public virtual string getDescription()
        {
            return description;
        }
        public abstract double cost();
    }

    public class Default : Beverage
    {
        public Default()
        {
            description = "";
        }
        public override double cost()
        {
            return 0;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend";
        }
        public override double cost()
        {
            return 1.2;
        }
    }

    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
        }
        public override double cost()
        {
            return 1.4;
        }
    }

    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }
        public override double cost()
        {
            return 1.7;
        }
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public override double cost()
        {
            return 1.9;
        }
    }

    public class SteamedMilk : Beverage
    {
        Beverage myBeverage;
        public SteamedMilk(Beverage beverage)
        {
            myBeverage = beverage;
        }
        public override string getDescription()
        {
            return myBeverage.getDescription() + " Steamed Milk";
        }

        public override double cost()
        {
            return myBeverage.cost() + 0.20;
        }
    }
    public class Mocha : Beverage
    {
        Beverage myBeverage;
        public Mocha(Beverage beverage)
        {
            myBeverage = beverage;
        }
        public override string getDescription()
        {
            return myBeverage.getDescription() + " Mocha";
        }
        public override double cost()
        {
            return myBeverage.cost() + 0.30;
        }
    }
    public class Soy : Beverage
    {
        Beverage myBeverage;
        public Soy(Beverage beverage)
        {
            this.myBeverage = beverage;
        }
        public override string getDescription()
        {
            return myBeverage.getDescription() + " Soy";
        }
        public override double cost()
        {
            return myBeverage.cost() + 0.25;
        }
    }

}