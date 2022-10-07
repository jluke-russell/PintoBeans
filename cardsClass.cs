using System;

namespace cse210_student_csharp_Hi_Lo
{   
    class cardClass
    {
        public int cardValue;

            public void getNewCard()
            {
                Random rnd = new Random();
                cardValue = rnd.Next(1,13);   
            }
    }
}       