using System;

namespace cse210_student_csharp_Hi_Lo
{
    class Card
    {
        public int cardValue;

        //After making a card class then generates a new card for the game.
        public void getNewCard()
        {
            Random randomGenerator = new Random();
            cardValue = randomGenerator.Next(1,14);
        }
    }
}