using System;
using System.Collections.Generic;

namespace cse210_student_csharp_Hi_Lo
{
    class Hilo
    {
        static void Main(string[] args)
        {
            int card = RandomCard();

            while (KeepPlaying())
            {
                Console.WriteLine($"The card is: {card}");
                Console.WriteLine($"Higher or Lower? (h/l)");
                Console.WriteLine($"Next card is: {cardClass}");
                Console.WriteLine($"Your score is: {pointsClass}");
                KeepPlaying()
            }
        }
        // keepPlayingB is the Boolean needed and keepPlayingS is the String value
        static bool KeepPlaying()
        {
            bool keepPlayingB = true;

            Console.WriteLine($"Play again? (yes/no)");
            string keepPlayingS = Console.ReadLine();

            if(keepPlayingS == "no")
            {
                keepPlayingB = false;
            }
            return keepPlayingB;
        }
    }
}
