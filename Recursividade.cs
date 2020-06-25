using System;

namespace Recursividade
{
    public class Recursividade
    {
        

        // GerarSequenciaFibonacci(0, 1, 15)
        // GerarSequenciaFibonacci(1, 1, 14)
        // GerarSequenciaFibonacci(1, 2, 13)
        // GerarSequenciaFibonacci(2, 3, 12)
        // GerarSequenciaFibonacci(3, 5, 11)
        public void GerarSequenciaFibonacci(int num1, int num2, int vezes){
            
            // Condição crucial da parada da recursividade
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if(vezes > 0){
                Console.WriteLine(num1);
                GerarSequenciaFibonacci(num2, num1 + num2, vezes - 1);
            }
            Console.ResetColor();
        }

        // GerarSequenciaTribonacci(1, 1, 2, 15)
        // GerarSequenciaTribonacci(1, 2, 4, 14)
        // GerarSequenciaTribonacci(2, 4, 7, 13)
        // GerarSequenciaTribonacci(4, 7, 13, 12)
        // GerarSequenciaTribonacci(7, 13, 24, 11)
        public void GerarSequenciaTribonacci(int num1, int num2, int num3, int vezes){
            Console.ForegroundColor = ConsoleColor.Yellow;
            if(vezes >= 0){
                Console.WriteLine(num1);
                GerarSequenciaTribonacci(num2 , num3, num1 + num2 + num3, vezes -1);
            }
            Console.ResetColor();
        }


        // 5! = 5 x 4 x 3 x 2 x 1 = 120
        public int GerarFatorial(int numero){
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if(numero == 1){
                return 1;
            }else{
                return numero * GerarFatorial(numero - 1);
            }
        }

        
    }
}