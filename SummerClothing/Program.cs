namespace SummerClothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a program that, based on the time of day and the temperature,
            // recommends to user what clothes to wear.
            // Example - Input: temperature = 16, time of day = Morning
            // Output: It's 16 degrees, get your Sweatshirt and Sneakers.

            int temperature = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            string clothing = string.Empty;
            string shoes = string.Empty;

            if (partOfDay == "Morning")
            {
                if (temperature >= 10 && temperature <= 18)
                {
                    clothing = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (temperature > 18 && temperature <= 24)
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if(temperature >= 25)
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (partOfDay == "Afternoon") 
            {
                if (temperature >= 10 && temperature <= 18)
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperature > 18 && temperature <= 24)
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (temperature >= 25)
                {
                    clothing = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (partOfDay == "Evening")
            {
                clothing = "Shirt";
                shoes = "Moccasins";
            }

            Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
        }
    }
}