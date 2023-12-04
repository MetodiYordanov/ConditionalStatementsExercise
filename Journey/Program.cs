namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a program that takes the budget and the season as inputs
            // from the console, and produces an output detailing where
            // the programmer will relax and how much he will spend.
            // Example - Input: budget = 50, season = summer
            // Output: Somewhere in Bulgaria, Camp - 15.00

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double amountSpent = 0;
            string destination = string.Empty;
            string holidayType = string.Empty;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    amountSpent = budget * 0.3;
                    holidayType = "Camp";
                }
                else if (season == "winter")
                {
                    amountSpent = budget * 0.7;
                    holidayType = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    amountSpent = budget * 0.4;
                    holidayType = "Camp";
                }
                else if (season == "winter")
                {
                    amountSpent = budget * 0.8;
                    holidayType = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                amountSpent = budget * 0.9;
                holidayType = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {amountSpent:F2}");
        }
    }
}