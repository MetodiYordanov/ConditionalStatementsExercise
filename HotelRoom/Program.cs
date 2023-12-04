namespace HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a program that computes the total cost of a stay for both
            // the studio and the apartment.
            // Example - Input: month = May, count of nights = 15
            // Output: Apartment: 877.50 lv., Studio: 525.00 lv.

            const double studioMayOctoberPrice = 50.0;
            const double apartmentMayOctoberPrice = 65.0;
            const double studioJuneSeptemberPrice = 75.2;
            const double apartmentJuneSeptemberPrice = 68.7;
            const double studioJulyAugustPrice = 76.0;
            const double apartmentJulyAugustPrice = 77.0;

            string monthOfHoliday = Console.ReadLine();
            int nightsOfHoliday = int.Parse(Console.ReadLine());

            double priceAllHolidayStudio = 0;
            double priceAllHolidayApartment = 0;

            if (monthOfHoliday == "May" || monthOfHoliday == "October")
            {
                priceAllHolidayStudio = nightsOfHoliday * studioMayOctoberPrice;
                priceAllHolidayApartment = nightsOfHoliday * apartmentMayOctoberPrice;

                if (nightsOfHoliday > 14)
                {
                    priceAllHolidayStudio -= priceAllHolidayStudio * 0.3;
                }
                else if (nightsOfHoliday > 7)
                {
                    priceAllHolidayStudio -= priceAllHolidayStudio * 0.05;
                }
            }
            else if (monthOfHoliday == "June" || monthOfHoliday == "September")
            {
                priceAllHolidayStudio = nightsOfHoliday * studioJuneSeptemberPrice;
                priceAllHolidayApartment = nightsOfHoliday * apartmentJuneSeptemberPrice;

                if(nightsOfHoliday > 14)
                {
                    priceAllHolidayStudio -= priceAllHolidayStudio * 0.2;
                }
            }
            else if (monthOfHoliday == "July" || monthOfHoliday == "August")
            {
                priceAllHolidayStudio = nightsOfHoliday * studioJulyAugustPrice;
                priceAllHolidayApartment = nightsOfHoliday * apartmentJulyAugustPrice;
            }

            if (nightsOfHoliday > 14)
            {
                priceAllHolidayApartment -= priceAllHolidayApartment * 0.1;
            }

            Console.WriteLine($"Apartment: {priceAllHolidayApartment:F2} lv.");
            Console.WriteLine($"Studio: {priceAllHolidayStudio:F2} lv.");
        }
    }
}