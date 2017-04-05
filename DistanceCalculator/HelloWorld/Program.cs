using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the distance (m)");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the time (h m s)");
            string timeInput = Console.ReadLine();

            string[] time = timeInput.Split(' ');

            int hours = Int32.Parse(time[0]);
            int minutes = Int32.Parse(time[1]);
            int seconds = Int32.Parse(time[2]);

            int finalTime = (hours * 3600) + (minutes * 60) + seconds;

            double speedIn_m_per_s = distance / finalTime;
            Console.Write("Your speed was " + speedIn_m_per_s + " meters per second\n");

            double speedIn_km_per_hour = (distance / 1000.0) / (finalTime / 3600.0);
            Console.Write("Your speed was " + speedIn_km_per_hour + " kilometers per hour\n");

            double speedIn_miles_per_hour = (distance / 1609.0) / (finalTime / 3600.0);
            Console.Write("Your speed was " + speedIn_miles_per_hour + " miles per hour\n");

            Console.ReadLine();
        }
    }
}
