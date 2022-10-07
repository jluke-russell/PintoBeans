using System;
using System.Collections.Generic;

namespace cse210_student_csharp_Hi_Lo
{
    class Hilo
    {
        bool isPlaying = true;
        int winningbonus = 100;
        int losingloss = 75;
        int totalScore = 300;

        int currentCard;
        int nextCard;
        static void Main(string[] args)
        {
            cardClass CardClass = new cardClass();
            while (KeepPlaying())
            {
                int card = CardClass.NextCard(1);
                Console.WriteLine($"The card is: {card}");
                Console.WriteLine($"Higher or Lower? (h/l)");
                Console.WriteLine($"Next card is: {cardClass}");
                Console.WriteLine($"Your score is: {pointsClass}");
                KeepPlaying();
            }
        }
        // keepPlayingB is the Boolean needed and keepPlayingS is the String value
        static bool KeepPlaying()
        {
            bool keepPlayingBool = true;

            Console.WriteLine($"Play again? (yes/no)");
            string? keepPlayingStr = Console.ReadLine();

            if(keepPlayingStr == "no")
            {
                keepPlayingBool = false;
            }
            return keepPlayingBool;
        }
        public void MainGame()
        {
            Console.WriteLine($"The card is {currentCard}");
            if (!isPlaying)
            {
                return;
            }

            foreach (cardClass card in cards){
                card.getNewCard();
                nextCard = card.cardValue;
            }
            Console.Write("Higher or Lower: [h/l]  ");
            string cardGuess = Console.ReadLine();
            Console.WriteLine($"The next card was:{nextCard}");
            if (cardGuess.Equals("h") && currentCard < nextCard){
                totalScore += winningbonus;
            }
            else if(cardGuess.Equals("l") && currentCard > nextCard){
                totalScore += winningbonus;
            }
            else if(cardGuess.Equals("h") && currentCard > nextCard){
                totalScore -= losingloss;
                if (totalScore < 0){
                    totalScore = 0;
                }
            }
            else if(cardGuess.Equals("l") && currentCard < nextCard){
                totalScore -= losingloss;
                if (totalScore < 0){
                    totalScore = 0;
                }
            }

        }


    }

}



