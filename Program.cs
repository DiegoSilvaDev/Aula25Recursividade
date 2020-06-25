using System;

namespace Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade rec = new Recursividade();
            rec.GerarSequenciaFibonacci(0,1,15);
            System.Console.WriteLine();
            Console.WriteLine(rec.GerarFatorial(5));
            rec.GerarSequenciaTribonacci(1,1,2,15);

        }
    }
}
