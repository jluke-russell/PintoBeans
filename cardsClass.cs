class cardClass
{
    public cards(){
        Random rnd = new Random();
        for (int j = 0; j < 4; j++){
            Console.WriteLine(rnd.Next(13));
        }
    }
}