using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01._26_08
{
    class Program
    {
        static void Main(string[] args)
        {

            //Operadadores Relacionais
            // && = E
            // || = ou
            // ! = não

            Console.WriteLine("Informe a sua altura: ");
            float altura = float.Parse(Console.ReadLine());

            //1,50 a 1,60 - P
            //1,61 a 1,70 - M
            // 1,70 a 1,80 - G
            // 1,81 - GG

            if (altura > 1.50 &&  altura < 1.60)
            {
                Console.WriteLine("Você usa tamanhp P");
            }
            else if (altura > 1.61 && altura < 1.70)
            {

            }
            else if (altura > 1.71 && altura < 1.80)
            {

            }

        }
    }
}
