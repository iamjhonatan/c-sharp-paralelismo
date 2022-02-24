using System;
using System.Threading;
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
            
            
            // Segundo exemplo:
            var inicio = DateTime.Now;
            while(true) {
                if (DateTime.Now - inicio >= TimeSpan.FromSeconds(5))
                    break;
            }

            Console.WriteLine(inicio);
            while (true)
            {
                Thread.Sleep((5000));
                Console.WriteLine(inicio - DateTime.Now);
                break;
            }
             /*
              O método Thread.Sleep(int) indica ao sistema operacional que aquela Thread não deve ser
              executada na CPU pelos próximos 5000 milissegundos, dando prioridade para outras Threads
              da aplicação ou outros programas a usarem a CPU da máquina. Enquanto que no código 1.
              temos um uso intensivo da CPU para o cálculo do período de tempo passado entre uma
              verificação e outra.
              */
            
             Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
             
             // Terceiro exemplo:
             var thread = new Thread(() => Thread.Sleep(5000));
             var isAlive = thread.IsAlive;
             Console.WriteLine(isAlive);
             /*
              A propriedade 'IsAlive' retorna true apenas enquanto estiver em execução.
              Como não foi iniciada, seu valor default false será retornado.
              */
        }
    }
}