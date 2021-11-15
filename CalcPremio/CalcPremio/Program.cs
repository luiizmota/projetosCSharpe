using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcPremio
{
    class Program
    {
        static void Main(string[] args)
        {
            
         
            //Receber o total das vendas
            Console.WriteLine("Informe o total de vendas do mês: ");
            float total = float.Parse(Console.ReadLine());

            float salario = total * 0.15f;
            // soma: +
            // substração: - 
            //multiplicação: *
            //divisão: /
            //toString com (C) - moeda
            //toString com N - Exibe o número com duas casas decimais

            Console.WriteLine("Sua comissão será de: R$ " + salario.ToString("C"));
            Console.ReadKey();
            
        }
    }
}
