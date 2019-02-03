using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompositePattern.Example1
{
    public class Example1Test
    {
        public static void Test()
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);
            allMenus.Add(dessertMenu);

            dinerMenu.Add(new MenuItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true, 3.89));
            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem("Apple Pie", "Apple pie with a flakey crust, topped with vanilla ice cream",
                true, 1.59));


            Waitress waitress = new Waitress(allMenus);

            Console.WriteLine("---------------------Menu----------------------");
            waitress.PrintMenu();
            Console.WriteLine("-------------Print Vegetarian Menu-------------");
            waitress.PrintVegetarianMenu();
        }
    }
}
