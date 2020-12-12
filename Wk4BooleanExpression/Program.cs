using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4BooleanExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int time;
            Console.WriteLine("What time is it?(use 24 hour clock)");
            time= Convert.ToInt32(Console.ReadLine());
            if(time<=1630)
            {
                Console.WriteLine("There's still time to look up a recipe.");
            }
            else if(time>=1631)
            {
                Console.WriteLine("Need to make plans quick.");
            }
            else
            {
                Console.WriteLine("please enter time in 24 hour clock");
            }

            string Recipe;
            Console.WriteLine("Do we have a recipe to use?");
            Recipe= Console.ReadLine();
            if(Recipe.Equals("no"))
            {
                Console.WriteLine("Might need to order out.");
            }
            else if (Recipe.Equals("yes"))
            {
                Console.WriteLine("Okay kets see if we can make it.");
            }
            else
            {
                Console.WriteLine("I didn't understand what you said.");
            }

            String ingredients;
            Console.WriteLine("Do we have everything we need?");
            ingredients= Console.ReadLine();
            if(ingredients.Equals("no"))
            {
                Console.WriteLine("okay we'll try something else.");
            }
            else if (ingredients.Equals("yes"))
            {
                Console.WriteLine("lets see what we can throw together.");
            }
            else
            {
                Console.WriteLine("I didn't understand what you said");
            }

            if (time >= 1630 && ingredients.Equals("no") && Recipe.Equals("no"))
            {
                Console.WriteLine("Guess we're ordering out");
            }
            else
            {
                Console.WriteLine("Let's get cooking");
            }
        }
    }
}
