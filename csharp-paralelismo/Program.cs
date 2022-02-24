using System;
using csharp_paralelismo.Exercises;

namespace csharp_paralelismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primeiro exemplo:
            var firstExercise = new Ex1();
            Console.WriteLine(firstExercise.FatorialEmParalelo(5));
            
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}