using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alfabetoIF
{
    class Program
    {
        static void Main(string[] args)
        {

            /*--------------------------------*/
            /*Imprimir o alfabeto utilizando o laço de repetição*/

            int i = 65;
            while (i < 91)
            {
                //tabela ascii numeros e caracteres
                //65 A
                char caracteres = System.Convert.ToChar(i);
                Console.WriteLine(i + " => " + caracteres);
                i++; //incremento, permite que o valor de i aumente até o limite definido no laço

            }
            Console.ReadKey();

        }
    }
}
