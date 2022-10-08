using System;

namespace cse210_student_csharp_Hi_Lo
{
    class Card
    {
        public int cardValue;

        ///Create a class for a card/draws a card
        public void getNewCard(){
            Random randomGenerator = new Random();
            cardValue = randomGenerator.Next(1,14);
        }
    }
}