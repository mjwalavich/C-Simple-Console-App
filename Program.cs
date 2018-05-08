using System;

namespace FitnessTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            int exerciseTime = 0;
            bool exerciseMore = true;

            while(exerciseMore)
            {
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");

                string entry = Console.ReadLine();

                if (entry =="quit")
                {
                    exerciseMore = false;
                }
                else
                {
                    int minutes = int.Parse(entry);

                    if(minutes <= 10)
                    {
                        Console.WriteLine("It is a good start");
                    }
                    else if(minutes <= 30)
                    {
                        Console.WriteLine("Keep up the momentum");
                    }
                    else if(minutes <= 60)
                    {
                        Console.WriteLine("Getting back in shape, I see");
                    }
                    else
                    {
                        Console.WriteLine("Showoff");
                    }

                    exerciseTime = exerciseTime + minutes;

                    Console.WriteLine("You've entered " + exerciseTime + " minutes");
                }
            }
            Console.WriteLine("Goodbye");
        }
    }
}
