using System;

namespace LiveCodingFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Candy("cloudy", 50));
        }

        static double Candy(string weather, int temp)
        {
            double trickTreaters = 250;
            double totalCandy = 0;
            //double totalCandyfinal = 0;
            temp = 0;
            

            if (weather == "clear")
            {
               totalCandy = trickTreaters + 0.10;
               if (temp == 40)
               {
                   totalCandy = (totalCandy - 0.05) * 3;
               }

               else if (temp == 50)
               {
                   totalCandy = (totalCandy - 0) * 3;
               }

               else if (temp == 60)
               {
                   totalCandy = (totalCandy + 0.05) * 3;
               }

               else if (temp == 70)
               {
                   totalCandy = (totalCandy + 0.20) * 3;
               }

                return totalCandy;
            }

            else if (weather == "cloudy")
            {
                totalCandy = (trickTreaters + 0) * 3;
                if (temp == 40)
                {
                    totalCandy = (totalCandy - 0.05) * 3;
                }

                else if (temp == 50)
                {
                    totalCandy = (totalCandy - 0) * 3;
                }

                else if (temp == 60)
                {
                    totalCandy = (totalCandy + 0.05) * 3;
                }

                else if (temp == 70)
                {
                    totalCandy = (totalCandy + 0.20) * 3;
                }

                return totalCandy;
            }

            else if (weather == "raining")
            {
               totalCandy = (trickTreaters - 0.25) * 3;
            }

            else if (weather == "full moon")
            {
               totalCandy = (trickTreaters + 0.25) * 3;
            }

            return totalCandy;

        }
    }
}
