using System;
using System.Collections.Generic;

namespace cse210_student_csharp_Hi_Lo
{
    public class Hilo
    {
        //Set up all the variables used for later on in the program
        List<Card> cards = new List<Card>();
        bool isPlaying = true;
        int winningbonus = 100;
        int losingloss = 75;
        int totalScore = 300;

        int currentCard;
        int nextCard;
        public Hilo()
        {
            for (int i = 0; i < 1; i++)
            {
                Card card = new Card();
                cards.Add(card);

            }
        }

        //This method starts the game from the original Program class.
        public void StartGame()
        {
            foreach (Card card in cards)
            {
                card.getNewCard();
                currentCard = card.cardValue;
            }
            while (isPlaying)
            {
                MainGame();
                GameCheck();
            }
        }

        //This Method is contains the actual game and the system it checks. 
        public void MainGame()
        {
            Console.WriteLine($"The card is {currentCard}");
            if (!isPlaying)
            {
                Console.WriteLine("Thanks for playing Hilo");
                return;
            }

            foreach (Card card in cards)
            {
                card.getNewCard();
                nextCard = card.cardValue;
            }
            Console.Write("Higher or Lower: [h/l]  ");
            string? cardGuess = Console.ReadLine();
            Console.WriteLine($"The next card was:{nextCard}");

            //Check the given answer to see if it was correct or wrong.
            if (cardGuess.Equals("h") && currentCard < nextCard)
            {
                totalScore += winningbonus;
            }
            else if(cardGuess.Equals("l") && currentCard > nextCard)
            {
                totalScore += winningbonus;
            }
            else if(cardGuess.Equals("h") && currentCard > nextCard)
            {
                totalScore -= losingloss;
                if (totalScore < 0){
                    totalScore = 0;
                }
            }
            else if(cardGuess.Equals("l") && currentCard < nextCard)
            {
                totalScore -= losingloss;
                if (totalScore < 0){
                    totalScore = 0;
                }
            }

        }

        //Checks the points after a decision to see if the user has lost then asks if they want to continue playing.
        public void GameCheck(){
            Console.WriteLine($"Your score is: {totalScore}");
            if (totalScore == 0)
            {
                isPlaying = false;
                
            }
            if (!isPlaying)
            {
                Console.Write("Thanks for playing Hilo");
                return;
            }

            //End by moving the new card to the current card and ask if they wish to keep playing.
            currentCard = nextCard;
            Console.Write("Keep Playing? [y/n] ");
            string? rollDice = Console.ReadLine();
            if (rollDice == "n")
            {
                Console.Write("Thanks for playing Hilo");
            }
            isPlaying = (rollDice == "y");
        }
    }
}