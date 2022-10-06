using System;

namespace cse210_student_csharp_Hi_Lo
{   
    class cardClass
    {
        public static int RandomCard()
        {
            Random rnd = new Random();
            int card = rnd.Next(1,13);
            return card;
        }
        public int NextCard(int needCard)
        {
            if (needCard == 1)
            {
                
                return currentCard;
            }
            else
            {
                int nextCard = RandomCard();
                int currentCard = nextCard;
                return nextCard;
            }
            
        }
    }
}
