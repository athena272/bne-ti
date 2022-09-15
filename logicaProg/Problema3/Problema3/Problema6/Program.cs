using System;

namespace Sample
{
    class Problema6
    {
        public static void Main(string[] args)
        {

            double valorInicial,valorPresente, taxaJuros, rendimento, acumulado, saldo;
            const int periodo = 8;

            Console.Write("Informe o valor inicial R$");
            valorInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a taxa de juros[%]: ");
            taxaJuros = Convert.ToDouble(Console.ReadLine());
            taxaJuros = taxaJuros / 100;

            int i = 1;
            //Iteracao acontecendo em um periodo de 8 meses e 10 dias
            do
            {
                acumulado = valorInicial * Math.Pow((1 + taxaJuros), i);
                valorPresente = acumulado;

                rendimento = acumulado - valorInicial;
                saldo = acumulado - rendimento;

                if(i == periodo)
                {
                    //Para encontrar quanto vale 10 dias
                    int convertToDay = (1 + periodo) / 3; //10 dias
                    acumulado = acumulado + (valorPresente * Math.Pow((1 + taxaJuros), convertToDay));
                    Console.WriteLine($"O rendimento final foi de: R${Math.Round(acumulado, 3)}");

                }
                i++;

            } while (i <= periodo);

        }
    }
}