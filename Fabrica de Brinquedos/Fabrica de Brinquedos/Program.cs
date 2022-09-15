using System;

namespace Fabrica_de_Pelé_de_borracha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######Teste de Produtividade######");
            double garrafa, disperdicio;
            string Produção;
            Console.Write("Digite a produção de hoje:");
            garrafa = double.Parse(Console.ReadLine());


            {
                if (garrafa >= 1000)

                    Produção = "Baixa Produtividade";
                else
                    Produção = "Prejuízo";
            }
            {
                if (garrafa >= 10000)

                    Produção = "Alta Produtividade";
            }
            disperdicio = (garrafa * 0,05);

            Console.WriteLine("O resultado da produção foi: {0}", Produção);

            Console.Write("Digite a produção para calcular o disperdicio:");
            

        


        }
    }
}