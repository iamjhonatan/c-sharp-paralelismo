using System.Threading;

namespace csharp_paralelismo.Exercises
{
    public class Ex1
    {
        /*
         Alteramos uma aplicação de cálculos matemáticos na execução de algumas funções paralelas
         a fim de tornar a aplicação responsiva!
        Com a implementação da função 'FatorialEmParalelo(int)' abaixo, obteremos qual comportamento
        ao chamar var a = 'FatorialEmParalelo(5)'?
        
        R: 0. A função FatorialEmParalelo retornará 0, pois ela não aguarda o término da thread
         t_calculo antes de retornar o valor da variável resultado, que se mantém 0.
         
         */
        public long FatorialEmParalelo(int valor) 
        { 
            long resultado = 0; 

            var t_calculo = new Thread(() => resultado = Fatorial(valor)); 
            t_calculo.Start(); 

            return resultado; 
        } 

        private long Fatorial(int valor)
        {
            var resultado = 1L;
            for (int i = valor; i >= 2; i--)
                resultado *= i;
            return resultado;
        }
    }
}