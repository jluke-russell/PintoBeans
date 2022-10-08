using cse210_student_csharp_Hi_Lo;

namespace cse210_student_csharp_Hi_Lo
{
    class Program{
        ///Begins game
        static int Main(string[] args){
            Director director = new Director();
            director.StartGame ();
            return 0;
        }
    }
}