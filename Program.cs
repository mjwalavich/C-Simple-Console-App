using System;

namespace FitnessTracker {
 class Program {
  static void Main(string[] args) {
   double exerciseTime = 0;
   bool exerciseMore = true;

   while (exerciseMore) {
    Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");

    string entry = Console.ReadLine();

    if (entry.ToLower() == "quit") {
     exerciseMore = false;
    } else {
     try {
      double minutes = double.Parse(entry);

      if (minutes <= 0) {
       Console.WriteLine("You cannot exercise for that amount of time.  Please enter another value.");
       continue;
      } else if (minutes <= 10) {
       Console.WriteLine("It is a good start");
      } else if (minutes <= 30) {
       Console.WriteLine("Keep up the momentum");
      } else if (minutes <= 60) {
       Console.WriteLine("Getting back in shape, I see");
      } else {
       Console.WriteLine("Showoff");
      }

      exerciseTime = exerciseTime + minutes;
     } catch (FormatException) {
      Console.WriteLine("Invalid input. Try again.");
      continue;
     }



     Console.WriteLine("You've entered " + exerciseTime + " minutes");
    }
   }
   Console.WriteLine("Goodbye");
  }
 }
}
