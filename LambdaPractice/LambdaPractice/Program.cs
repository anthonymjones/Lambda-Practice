using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", 
                "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};


            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            List<string> kayakProducts = products.Where(x => x.Contains("Kayak")).ToList();
            //print the kayakProducts to the console using a foreach loop.
            foreach (var kayak in kayakProducts)
            {
                Console.WriteLine(kayak);
            }
            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            List<string> shoeProducts = products.Where(x => x.Contains("Shoes")).ToList();
            //print the shoeProducts to the console using a foreach loop or string.Join().
            Console.WriteLine("All Shoe Products: " + string.Join(", ", shoeProducts));
            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            List<string> ballProducts = products.Where(x => x.ToLower().Contains("ball")).ToList();
            //print the ballProducts to the console using a foreach loop or string.Join().
            Console.WriteLine("All Ball Products: " + string.Join(", ", ballProducts));
            //sort ballProducts alphabetically and print them to the console.
            Console.WriteLine("All Ball Products in Alphabetical Order: " + string.Join(", ", ballProducts.OrderBy(x => x)));
            //add six more items to the products list using .add().
            products.Add("Tennis Ball");
            products.Add("Golf Clubs");
            products.Add("Bicycle");
            products.Add("Long Board");
            products.Add("Bat");
            products.Add("Hockey Stick");
            //print the product with the longest name to the console using the .First() extension.
            Console.WriteLine("Product with the longest name: " + products.OrderByDescending(x => x.Length).First());
            //print the product with the shortest name to the console using OrderByDesceding() and the .Last() extension.
            Console.WriteLine("Product with the shortest name: " + products.OrderByDescending(x => x.Length).Last());
            //print the product with the 4th shortest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            //Console.WriteLine(products.OrderBy(x => x.Length).ToList()[3]);
            Console.WriteLine("The 4th shortest product name: " + products.OrderBy(x => x.Length).Skip(3).Take(1).First());
            //print the ballProduct with the 2nd longest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            Console.WriteLine("Ball product with the 2nd longest name: " + ballProducts.OrderByDescending(x => x.Length).Skip(1).First());
            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDescending() extension).
            List<string> reversedProducts = products.OrderByDescending(x => x.Length).ToList();
            Console.WriteLine("All products by longest name: " + string.Join(", ", reversedProducts));
            //print out the reversedProducts to the console using a foreach loop.
            foreach (var all in reversedProducts)
            {
                Console.WriteLine(all);
            }
            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            foreach (var item in products.OrderByDescending(x => x.Length))
            {
                Console.WriteLine(item);
            }
            //Note: you will not use a variable to store your list


            Console.ReadKey();
        }

    }
}