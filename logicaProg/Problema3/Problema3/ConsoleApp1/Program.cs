using System;

namespace Sample
{
    class Problema3
    {
        public static void Main(string[] args)
        {
            string userInput;
            double valorPresente, taxaJuros, periodo, rendimento;
            Console.Write("Informe o valor presente R$");
            userInput = Console.ReadLine();
            /* Converts to double type */
            valorPresente = Convert.ToDouble(userInput);

            Console.Write("Informe a taxa de juros: ");
            userInput = Console.ReadLine();
            /* Converts to double type */
            taxaJuros = Convert.ToDouble(userInput);
            taxaJuros = taxaJuros / 100;

            Console.Write("Informe o período em meses: ");
            userInput = Console.ReadLine();
            /* Converts to double type */
            periodo = Convert.ToDouble(userInput);

            rendimento = valorPresente * (Math.Pow((1 + taxaJuros), periodo));
            Console.WriteLine($"O rendimento foi de R${Math.Round(rendimento, 2)}");

        }
    }
}