namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a program that reads the type of screening (string), the number of rows and the number of columns
            // in the hall (integers) entered by the user, and calculates the total ticket revenue at a full hall.
            // Example -  Input: premiere screening = Normal, number of rows = 21,
            // number of columns = 13
            // Output: 2047.50 leva

            double premierePrice = 12.0;
            double normalPrice = 7.5;
            double discountedPrice = 5;
            double ticketsRevenue = 0;

            string typeMovie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            if (typeMovie == "Premiere")
            {
                ticketsRevenue = premierePrice * rows * columns;
            }
            else if (typeMovie == "Normal")
            {
                ticketsRevenue = normalPrice * rows * columns;
            }
            else if (typeMovie == "Discount")
            {
                ticketsRevenue = discountedPrice * rows * columns;
            }
            Console.WriteLine($"{ticketsRevenue:f2} leva");
        }
    }
}