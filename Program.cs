using System;

namespace Exercicios_com_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você deseja receber um bom dia?");
            string resposta = Console.ReadLine();

            int numeroDeVezes = 0;

            while(resposta == "Sim") {
                //Executado quando a condição é verdadeira
                Console.WriteLine("Bom dia!");

                numeroDeVezes++;

                Console.WriteLine("Ainda deseja receber um bom dia?");
                resposta = Console.ReadLine();
            }
            Console.WriteLine($"Numero de vezes: {numeroDeVezes}");
            Console.WriteLine("Fim do programa");
        }
    }
}
