using System;

namespace CsE9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXECÍCIO 9
            Console.WriteLine("Descobrindo numeros multiplos\n\nINFORME DOIS VALORES Ex(1  2): ");
            string[] vet = Console.ReadLine().Split(' ');
            int v1 = int.Parse(vet[0]);
            int v2 = int.Parse(vet[1]);
            //SE QUANDO DIVIDIDOS ENTRI SI TEREM COMO RESTO 0 SERÃO MÚLTIPLOS
            if (v1 % v2 == 0 || v2 % v1 == 0)
                Console.WriteLine("\nMULTIPLOS");
            else 
                Console.WriteLine("\nNAO MULTIPLOS");
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
