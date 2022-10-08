using cse210_student_csharp_Hi_Lo;

namespace cse210_student_csharp_Hi_Lo
{
    class Program{
        //Simple program to start the program by calling the StartGame method.
        static int Main(string[] args){
            Hilo hilo = new Hilo();
            hilo.StartGame ();
            return 0;
        }
    }
}