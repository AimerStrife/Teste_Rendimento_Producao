using System;

namespace Fabrica_de_Pelé_de_borracha
{
    internal class Program
    {

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("dd/MM/yyyy");
        }
        static void Main(string[] args)
        {
            /* Programa: Calculador de produção
             * Função: Insere a produção diária de uma fábrica e retorna se foi produtivo 
             * Data: 22/04/2022
             * Autores:
             */

            //variáveis
            String hora = GetTimestamp(DateTime.Now);
            double garrafa, desperdicio;
            string Produção;

            //início
            Console.WriteLine("######Teste de Produtividade######");
            //entrada de dados
            Console.WriteLine("\nDigite a produção de garrafas de hoje: ({0})", hora);
            garrafa = double.Parse(Console.ReadLine());

            //processamento
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

            desperdicio = (garrafa * 0.05);

            //saída de dados
            Console.WriteLine("O resultado da produção de {0} foi: {1} \n", hora, Produção, desperdicio);





            Console.ReadKey();

        }
    }
}
