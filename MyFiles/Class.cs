//Class.cs

namespace PizzaMaker
{
    public class Pizza
    {
            public enum Crust
            {
                Thin,
                Thick,
                Cauliflower
            };
            public enum Sauce
            {
                Tomato,
                Barbecue,
                Alfredo
            };
            public enum Cheese
            {
                Mozzarella,
                Provolone,
                Gorgonzola
            };
            public enum Toppings
            {
                Mushrooms,
                Olives,
                Peppers,
                Pepperoni,
                Pineapple,
                Anchovies
            };
            public int ToppingsCount;
            public bool isReady;
            public double TotalPrice;

            public void ChooseCrust()
            {
                Console.WriteLine("What kind of crust would you like?");
            }
            public void ChooseSauce()
            {
                Console.WriteLine("What kind of sauce would you like?");
            }
            public void ChooseCheese()
            {
                Console.WriteLine("What kind of cheese would you like?");
            }
            public void ChooseToppings()
            {
                Console.WriteLine("What kind of toppings would you like?");
            }
            public void CalculateTotal()
            {
                Console.WriteLine("PLACEHOLDER");
            }
    }
}