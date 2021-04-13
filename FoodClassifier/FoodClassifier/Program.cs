// define a scope of which an object will be disposed [storage/data structure]

using System;
using System.Collections;

namespace FoodClassifier // declare a scope
{
    class Program // class
    {
        static void Main(string[] args) // main method
        {
            Hashtable foodSelection = new Hashtable() // create a hashtable
            {
                { "Bacon-Pimiento Guacamole", "Appetizer" },
                { "Crispy Baked Chicken Wings", "Appetizer" },
                { "Ham-and-Cheese Sliders", "Appetizer" },
                { "Sweet Potato and Chorizo Sausage Bites", "Appetizer" },
                { "Quick Pickled Brussels Sprouts", "Appetizer" },
                { "Mini Black Bean and Cheese Enchiladas", "Appetizer" },
                { "Cheese Snappy Wafers", "Appetizer"},
                { "Cardamom Maple Salmon", "Main Course"},
                { "Spicy Pork Tenderloin with Apples and Sweet Potatoes", "Main Course"},
                { "Gemelli Pasta with Roasted Pumpkin and Pancetta", "Main Course"},
                { "Cauliflower Bolognese", "Main Course"},
                { "Chicken Stew with Potatoes and Radishes", "Main Course"},
                { "Chocolate Cookie Icebox Dessert", "Dessert"},
                { "Creamy Rice Pudding", "Dessert"},
                { "Spanish Flan", "Dessert"},
                { "Tiramisu", "Dessert"},
                { "S'mores", "Dessert"},
                { "Rum Cake", "Dessert"},
                { "Toasted Coconut Toffee Chocolate Chip Cookies", "Dessert"},
                { "Malva Pudding", "Dessert"}
            };
            // perform operation "for each" object in the hashmap
            foreach (DictionaryEntry food in foodSelection)
                // operation to be performed
                Console.WriteLine("Food's Name: {0} \nFood Type: {1}", food.Key, food.Value, "\n");
        }
    }
}
