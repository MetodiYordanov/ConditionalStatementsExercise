namespace SkiHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double priceRoomOnePerson = 118.0;
            const double priceApartment = 155.0;
            const double pricePresidentApartment = 235.0;

            int daysToStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string assessment = Console.ReadLine();
            
            int numberOfNights = daysToStay - 1;
            double finalPrice = 0;

            if (daysToStay < 10)
            {
                switch (typeOfRoom)
                {
                    case "apartment":
                        finalPrice = numberOfNights * priceApartment;
                        finalPrice -= finalPrice * 0.3;
                        break;
                    case "president apartment":
                        finalPrice = numberOfNights * pricePresidentApartment;
                        finalPrice -= finalPrice * 0.1;
                        break;
                    default:
                        finalPrice = numberOfNights * priceRoomOnePerson; 
                        break;
                }
            }
            else if (daysToStay >= 10 && daysToStay <= 15)
            {
                switch (typeOfRoom)
                {
                    case "apartment":
                        finalPrice = numberOfNights * priceApartment;
                        finalPrice -= finalPrice * 0.35;
                        break;
                    case "president apartment":
                        finalPrice = numberOfNights * pricePresidentApartment;
                        finalPrice -= finalPrice * 0.15;
                        break;
                    default:
                        finalPrice = numberOfNights * priceRoomOnePerson;
                        break;
                }
            }
            else if (daysToStay > 15)
            {
                switch (typeOfRoom)
                {
                    case "apartment":
                        finalPrice = numberOfNights * priceApartment;
                        finalPrice -= finalPrice * 0.5;
                        break;
                    case "president apartment":
                        finalPrice = numberOfNights * pricePresidentApartment;
                        finalPrice -= finalPrice * 0.2;
                        break;
                    default:
                        finalPrice = numberOfNights * priceRoomOnePerson;
                        break;
                }
            }

            if (assessment == "positive")
            {
                finalPrice += finalPrice * 0.25;
            }
            else if (assessment == "negative")
            {
                finalPrice -= finalPrice * 0.1;
            }

            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}