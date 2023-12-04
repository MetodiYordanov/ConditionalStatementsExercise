namespace OnTimeForExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a program that reads the exam time and the time of arrival,
            // and then prints whether the student is on time, early, or late,
            // along with the number of hours or minutes he is early or late.
            // Example - Input: exam time (hour) = 9, exam time (minutes) = 30,
            // time of arrival (hour) = 9, time of arrival (minutes) = 50
            // Output: Late, 20 minutes after the start

            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examHourInMinutes = examHour * 60;
            int examHoursPlusMinutes = examHourInMinutes + examMinutes;

            int arrivalHourInMinutes = arrivalHour * 60;
            int arrivalHoursPlusMinutes = arrivalHourInMinutes + arrivalMinutes;

            int timeDifferenceInMinutes = examHoursPlusMinutes - arrivalHoursPlusMinutes;

            string lateOrOnTime = string.Empty;

            int timeDifferenceHours = 0;
            int timeDifferenceLeftMinutes = 0;

            if (timeDifferenceInMinutes < 0)
            {
                lateOrOnTime = "Late";
                timeDifferenceInMinutes *= -1;

                timeDifferenceHours = arrivalHoursPlusMinutes / examHoursPlusMinutes;
                timeDifferenceLeftMinutes = arrivalHoursPlusMinutes % examHoursPlusMinutes;
            }
            else if (timeDifferenceInMinutes == 0)
            {
                lateOrOnTime = "On time";
                Console.WriteLine($"{lateOrOnTime}");
                return;
            }
            else if (timeDifferenceInMinutes > 0)
            {
                if (timeDifferenceInMinutes <= 30)
                {
                    lateOrOnTime = "On time";
                }
                else
                {
                    lateOrOnTime = "Early";
                }

                timeDifferenceHours = examHoursPlusMinutes / arrivalHoursPlusMinutes;
                timeDifferenceLeftMinutes = examHoursPlusMinutes % arrivalHoursPlusMinutes;
            }

            Console.WriteLine(lateOrOnTime);

            if (lateOrOnTime == "Late")
            {
                if(timeDifferenceInMinutes <= 59)
                {
                    Console.WriteLine($"{timeDifferenceInMinutes} minutes after the start");
                }
                else
                {
                    if (timeDifferenceLeftMinutes == 60)
                    {
                        Console.WriteLine($"{timeDifferenceHours}:00 hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{timeDifferenceHours}:{timeDifferenceLeftMinutes} hours after the start");
                    }
                }
            }
            else
            {
                if (timeDifferenceInMinutes <= 59)
                {
                    Console.WriteLine($"{timeDifferenceInMinutes} minutes before the start");
                }
                else
                {
                    if (timeDifferenceLeftMinutes == 60)
                    {
                        Console.WriteLine($"{timeDifferenceHours}:00 hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{timeDifferenceHours}:{timeDifferenceLeftMinutes} hours before the start");
                    }
                }
            }
        }
    }
}