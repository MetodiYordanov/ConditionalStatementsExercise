namespace FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a program that calculates whether the fishermen will be able
            // to gather enough money for the fishing trip based on different conditions.
            // Example - Input: group budget = 3000, season = Summer, fishermen count = 11
            // Output: Not enough money! You need 570.00 leva.

            const double springPrice = 3000.0;
            const double summerAndAutumnPrice = 4200.0;
            const double winterPrice = 2600.0;

            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());

            double neededMoney = 0;
            double leftMoney = 0;

            if (season == "Spring")
            {
                neededMoney = springPrice;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                neededMoney = summerAndAutumnPrice;
            }
            else if (season == "Winter")
            {
                neededMoney = winterPrice;
            }

            if (fishermenCount <= 6)
            {
                neededMoney -= neededMoney * 0.1;
            }
            else if (fishermenCount >= 7 && fishermenCount <= 11) 
            {
                neededMoney -= neededMoney * 0.15;
            }
            else if (fishermenCount >= 12)
            {
                neededMoney -= neededMoney * 0.25;
            }

            if (fishermenCount % 2 == 0 && season != "Autumn")
            {
                neededMoney -= neededMoney * 0.05;
            }

            leftMoney = groupBudget - neededMoney;

            if (leftMoney >= 0)
            {
                Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
            }
            else
            {
                leftMoney *= -1;
                Console.WriteLine($"Not enough money! You need {leftMoney:F2} leva.");
            }
        }
    }
}