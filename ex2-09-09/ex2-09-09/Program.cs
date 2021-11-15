using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_09_09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----------------------------------------------*/
            Console.WriteLine("Está chovendo aí?");
            string tempo = Console.ReadLine();
            while(tempo == "sim")
            {
                Console.WriteLine("Levar o guarda-chuva");

                Console.Write("Está chovendo aí?");
                tempo = Console.ReadLine();
            }
            /*--------------------------------------*/
            int i = 0;
            while (i<100)
            {
                Console.WriteLine("Está chovendo aqui...");
                i++;
            }
            /*--------------------------------*/
            /*Imprimir o alfabeto utilizando o laço de repetição*/

            int i = 0;
            while(i < 30)
            {

            }
        }
    }
}
