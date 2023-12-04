namespace NewHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is program that calculates how much it will cost users, to plant
            // a certain number of flowers and whether the available budget will be enough for them.
            // Example - Input: type of flowers = Roses, flowers count =  55,
            // budget = 250; Output: Not enough money, you need 25.00 leva more.

            const double rosePrice = 5.0;
            const double dahliaPrice = 3.8;
            const double tulipPrice = 2.8;
            const double narcissPrice = 3.0;
            const double gladiolPrice = 2.5;

            string flowerType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double neededMoney = 0;
            double leftMoney = 0;

            if (flowerType == "Roses")
            {
                neededMoney = rosePrice * flowersCount;
                if (flowersCount > 80) 
                {
                    neededMoney -= neededMoney * 0.1;
                }
            }
            else if (flowerType == "Dahlias")
            {
                neededMoney = dahliaPrice * flowersCount;
                if(flowersCount > 90)
                {
                    neededMoney -= neededMoney * 0.15;
                }
            }
            else if (flowerType == "Tulips")
            {
                neededMoney = tulipPrice * flowersCount;
                if (flowersCount > 80)
                {
                    neededMoney -= neededMoney * 0.15;
                }
            }
            else if (flowerType == "Narcissus")
            {
                neededMoney = narcissPrice * flowersCount;
                if (flowersCount < 120)
                {
                    neededMoney += neededMoney * 0.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                neededMoney = gladiolPrice * flowersCount;
                if (flowersCount < 80)
                {
                    neededMoney += neededMoney * 0.2;
                }
            }

            leftMoney = budget - neededMoney;

            if (leftMoney >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType} and {leftMoney:F2} leva left.");
            }
            else
            {
                leftMoney *= -1;
                Console.WriteLine($"Not enough money, you need {leftMoney:F2} leva more.");
            }
        }
    }
}