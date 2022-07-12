using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class MainSystem
    {
        Menu myMenu = new DefaultMenu();
        Menu myChickenRice = new ChickenRice();
        Menu myMeatRice = new MeatRice();
        Menu myEggRice = new EggRice();
        Menu myMixedRice = new MixedRice();

        static void Main(string[] args)
        {
            MainSystem mainSystem = new MainSystem();
            mainSystem.DisplayMenu();
        }
        public void DisplayMenu()
        {
            Menu myWaterSpinach = new WaterSpinach(myMenu);
            Menu myOmelet = new Omelet(myMenu);
            Menu mySoup = new Soup(myMenu);
            Menu mySoftDrink = new SoftDrink(myMenu);

            Console.WriteLine("*=*=*=*=*=*= Menu Traditional Food =*=*=*=*=*=*\n");
            //Main course
            Console.WriteLine("=================== Main Course ===================");
            Console.WriteLine($"{myChickenRice.getDescription()}: ${myChickenRice.price()}");
            Console.WriteLine($"{myMeatRice.getDescription()}: ${myMeatRice.price()}");
            Console.WriteLine($"{myEggRice.getDescription()}: ${myEggRice.price()}");
            Console.WriteLine($"{myMixedRice.getDescription()}: ${myMixedRice.price()}\n");
            //Side Dish
            Console.WriteLine("=================== Side Dish ===================");
            Console.WriteLine($"{myWaterSpinach.getDescription()}: ${myWaterSpinach.price()}");
            Console.WriteLine($"{myOmelet.getDescription()}: ${myOmelet.price()}");
            Console.WriteLine($"{mySoup.getDescription()}: ${mySoup.price()}");
            Console.WriteLine($"{mySoftDrink.getDescription()}: ${mySoftDrink.price()}");
        }
    }
}

