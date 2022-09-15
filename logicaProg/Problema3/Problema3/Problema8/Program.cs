using System;

namespace Sample
{
    class Problema8
    {
        public static void Main(string[] args)
        {

            double valorInicial, valorPresente, taxaJuros, rendimento, acumulado, saldo;
            int periodo, periodoResgate;

            Console.Write("Informe o valor inicial R$");
            valorInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a taxa de juros[%]: ");
            taxaJuros = Convert.ToDouble(Console.ReadLine());
            taxaJuros = taxaJuros / 100;

            Console.Write("Informe o período em meses: ");
            periodo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe em que mes deseja fazer uma resgate: ");
            periodoResgate = Convert.ToInt32(Console.ReadLine());


            int i = 1;
            int mesAtual = 1;
            
            do
            {
                acumulado = valorInicial * Math.Pow((1 + taxaJuros), i);
                
                rendimento = acumulado - valorInicial;
                Console.Write($"Rendimento do {i}º mes, R${rendimento}");

                if (periodoResgate == periodo)
                {
                    Console.WriteLine("Chegou o mes escolhido para o resgate");
                    Console.Write($"O valor de resgate no mes {periodoResgate}, foi de R${rendimento}");
                    i = 1;
                    mesAtual++;
                    continue;

                }
                i++;
                mesAtual++;

            } while (mesAtual <= periodo);

        }
    }
}