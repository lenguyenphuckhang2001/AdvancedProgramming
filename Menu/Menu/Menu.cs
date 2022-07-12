using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public abstract class Menu
    {
        protected string description = "Default";
        public virtual string getDescription()
        {
            return description;
        }
        public abstract double price();
    }

    public class DefaultMenu : Menu
    {
        public DefaultMenu()
        {
            description = "";
        }
        public override double price()
        {
            return 0;
        }
    }

    //Order Menu
    public class ChickenRice : Menu
    {
        public ChickenRice()
        {
            description = "Chicken Rice";
        }
        public override double price()
        {
            return 35.000;
        }
    }

    public class MeatRice : Menu
    {
        public MeatRice()
        {
            description = "Meat Rice";
        }
        public override double price()
        {
            return 25.000;
        }
    }

    public class EggRice : Menu
    {
        public EggRice()
        {
            description = "Egg Rice";
        }
        public override double price()
        {
            return 20.000;
        }
    }

    public class MixedRice : Menu
    {
        public MixedRice()
        {
            description = "Egg Rice";
        }
        public override double price()
        {
            return 30.000;
        }
    }

    //Order more side dishes
    public class WaterSpinach : Menu
    {
        Menu myMenu;
        public WaterSpinach(Menu menu)
        {
            this.myMenu = menu;
        }
        public override string getDescription()
        {
            return myMenu.getDescription() + "Water Spinach";
        }
        public override double price()
        {
            return myMenu.price() + 3.000;
        }
    }

    public class Omelet : Menu
    {
        Menu myMenu;
        public Omelet(Menu menu)
        {
            this.myMenu = menu;
        }
        public override string getDescription()
        {
            return myMenu.getDescription() + "Omelet";
        }
        public override double price()
        {
            return myMenu.price() + 6.000;
        }
    }

    public class Soup : Menu
    {
        Menu myMenu;
        public Soup(Menu menu)
        {
            this.myMenu = menu;
        }
        public override string getDescription()
        {
            return myMenu.getDescription() + "Soup";
        }
        public override double price()
        {
            return myMenu.price() + 5.000;
        }
    }

    public class SoftDrink : Menu
    {
        Menu myMenu;
        public SoftDrink(Menu menu)
        {
            this.myMenu = menu;
        }
        public override string getDescription()
        {
            return myMenu.getDescription() + "SoftDrink";
        }
        public override double price()
        {
            return myMenu.price() + 10.000;
        }
    }


}