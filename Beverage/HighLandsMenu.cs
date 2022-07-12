using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berverage
{
    class HighLandsMenu
    {
        Beverage myBeverage = new Default();
        Beverage myHouseBlend = new HouseBlend();
        Beverage myDarkRoast = new DarkRoast();
        Beverage myDecaf = new Decaf();
        Beverage myEspresso = new Espresso();
        //Create a Customer's order Beverage
        Beverage customerBeverage;
        //Confirm the customer's order
        bool confirm = true;
        //Char will use to ask user Yes or No
        char yesNo = 'N';
        int chooseCoffee;
        int chooseCondiments;

        static void Main(string[] args)
        {
            HighLandsMenu highLandsMenu = new HighLandsMenu();
            highLandsMenu.Loading();
            highLandsMenu.ShowCoffee();
        }
        public void ShowMenu()
        {
            Beverage mySteamedMilk = new SteamedMilk(myBeverage);
            Beverage myMocha = new Mocha(myBeverage);
            Beverage mySoy = new Soy(myBeverage);
            Console.WriteLine("----\tHighlands Coffee Menu\t----");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("== Coffees ");
            Console.ResetColor();
            Console.WriteLine($" \t{myHouseBlend.getDescription()}: \t\t${myHouseBlend.cost()}");
            Console.WriteLine($" \t{myDarkRoast.getDescription()}: \t\t${myDarkRoast.cost()}");
            Console.WriteLine($" \t{myDecaf.getDescription()}: \t\t\t${myDecaf.cost()}");
            Console.WriteLine($" \t{myEspresso.getDescription()}: \t\t${myEspresso.cost()}");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("== Condiments ");
            Console.ResetColor();
            Console.WriteLine($" {mySteamedMilk.getDescription()}: \t\t\t${mySteamedMilk.cost()}");
            Console.WriteLine($" {myMocha.getDescription()}: \t\t\t${myMocha.cost()}");
            Console.WriteLine($" {mySoy.getDescription()}: \t\t\t${mySoy.cost()}");
        }
        public void Loading()
        {
            Console.WriteLine("\t    WELCOME TO HIGHLANDS COFFEE CONSOLE APPLICATION     \t");
            Console.WriteLine("------------------------------------------------------------");
            ShowMenu();
            
        }

    
        public void ShowCoffee()
        {
            Console.WriteLine("----\tHighlands Coffee\t----");
            Console.WriteLine($" [1] \t{myHouseBlend.getDescription()}: \t\t${myHouseBlend.cost()}");
            Console.WriteLine($" [2] \t{myDarkRoast.getDescription()}: \t\t${myDarkRoast.cost()}");
            Console.WriteLine($" [3] \t{myDecaf.getDescription()}: \t\t\t${myDecaf.cost()}");
            Console.WriteLine($" [4] \t{myEspresso.getDescription()}: \t\t${myEspresso.cost()}");
            Console.Write("\n Choose Coffee: ");
            chooseCoffee = Int32.Parse(Console.ReadLine());
            try
            {
                while (confirm)
                {
                    switch (chooseCoffee)
                    {
                        case 0:
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{myHouseBlend.getDescription()}:${myHouseBlend.cost()}");
                            Console.ResetColor();
                            customerBeverage = new HouseBlend();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{myDarkRoast.getDescription()}: ${myDarkRoast.cost()}");
                            Console.ResetColor();
                            customerBeverage = new DarkRoast();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{myDecaf.getDescription()}: ${myDecaf.cost()}");
                            Console.ResetColor();
                            customerBeverage = new Decaf();
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{myEspresso.getDescription()}: ${myEspresso.cost()}");
                            Console.ResetColor();
                            customerBeverage = new Espresso();
                            break;
                        default:
                            break;
                    }
                    if (chooseCoffee > 4)
                    {
                        Console.WriteLine("Please Coffee in menu");
                        Console.Write("Choose Coffee: ");
                        chooseCoffee = Int32.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.Write("-Do you want this Coffee? (Y: Yes, N: No): ");
                        yesNo = char.Parse(Console.ReadLine());
                        if (yesNo == 'Y' || yesNo == 'y')
                            break;
                        Console.Write("Choose Coffee: ");
                        chooseCoffee = Int32.Parse(Console.ReadLine());
                    }
                }
            }
            catch (System.Exception)
            {
                try
                {
                    Console.Write("-Do you want to add more Condiments? (Y: Yes, N: No): ");
                    yesNo = char.Parse(Console.ReadLine());
                    if (yesNo == 'Y' || yesNo == 'y')
                    {
                        ShowCondiments();
                    }
                    else
                    {
                        confirm = false;
                        Receipt();
                    }
                }
                catch (System.Exception)
                {
                    ShowCondiments();
                }
            }
            if (confirm)
            {
                try
                {
                    Console.Write("-Do you want to add more Condiments? (Y: Yes, N: No): ");
                    yesNo = char.Parse(Console.ReadLine());
                    if (yesNo == 'Y' || yesNo == 'y')
                    {
                        ShowCondiments();
                    }
                    else Receipt();
                }
                catch (System.Exception)
                {
                    ShowCondiments();
                }
            }
        }
        public void ShowCondiments()
        {
            Beverage mySteamedMilk = new SteamedMilk(myBeverage);
            Beverage myMocha = new Mocha(myBeverage);
            Beverage mySoy = new Soy(myBeverage);
            Console.WriteLine("----\t Highlands Condimentes \t----");
            Console.WriteLine($" [1] {mySteamedMilk.getDescription()}: \t\t${mySteamedMilk.cost()}");
            Console.WriteLine($" [2] {myMocha.getDescription()}: \t\t\t${myMocha.cost()}");
            Console.WriteLine($" [3] {mySoy.getDescription()}: \t\t\t${mySoy.cost()}");
            try
            {
                Console.Write("\n Add Condimentes (Press 'Enter' to done): ");
                chooseCondiments = Int32.Parse(Console.ReadLine());
                while (confirm)
                {
                    switch (chooseCondiments)
                    {
                        case 1:
                            customerBeverage = new SteamedMilk(customerBeverage);
                            Console.WriteLine($"Added:{mySteamedMilk.getDescription()}");
                            break;
                        case 2:
                            customerBeverage = new Mocha(customerBeverage);
                            Console.WriteLine($"Added:{myMocha.getDescription()}");
                            break;
                        case 3:
                            customerBeverage = new Soy(customerBeverage);
                            Console.WriteLine($"Added:{mySoy.getDescription()}");
                            break;
                        default:
                            break;
                    }
                    if (chooseCondiments > 4)
                    {
                        Console.WriteLine("Please choose Condimentes in menu");
                    }
                    Console.Write("\nAdd Condimentes (Press 'Enter' to done): ");
                    chooseCondiments = Int32.Parse(Console.ReadLine());
                }
            }
            catch (System.Exception)
            {
                confirm = false;
                Receipt();
            }
        }
        public void Receipt()
        {
            Console.WriteLine("\n--- \tCustomer order \t---");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("--Beverage--\t");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("--Condiments--");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"{customerBeverage.getDescription()}");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("--Price: ");
            Console.ResetColor();
            Console.Write($"${customerBeverage.cost()}");
            Console.WriteLine("\n\nThank you for using our service!");
        }
    }
}


