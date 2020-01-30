using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeLogico
{
    class Program
    {
        static void Main(string[] args)
        {
            int posicao = 1;

            int[,] caminho = new int[5, 4] 
            { {1, 1, 1, 1 }, 
              {0, 1, 1, 0 }, 
              {0, 1, 0, 1 }, 
              {0, 1, 9, 1 }, 
              {1, 1, 1, 1 } };


            System.Console.WriteLine(caminho[0, 0] + "," + caminho[0, 1] + "," + caminho[0, 2] + "," + caminho[0, 3]);
            System.Console.WriteLine(caminho[1, 0] + "," + caminho[1, 1] + "," + caminho[1, 2] + "," + caminho[1, 3]);
            System.Console.WriteLine(caminho[2, 0] + "," + caminho[2, 1] + "," + caminho[2, 2] + "," + caminho[2, 3]);
            System.Console.WriteLine(caminho[3, 0] + "," + caminho[3, 1] + "," + caminho[3, 2] + "," + caminho[3, 3]);
            System.Console.WriteLine(caminho[4, 0] + "," + caminho[4, 1] + "," + caminho[4, 2] + "," + caminho[4, 3]);
            System.Console.ReadKey();



            posicao = caminho[0, 0];
            Console.WriteLine("\n"+posicao);


            for (int j = 0; j < 5; j++)
            {


                if (j < 4)
                {
                    posicao = caminho[j, 1];

                    Console.WriteLine(posicao);
                }
                else
                {
                    posicao = caminho[3, 2];

                    Console.Write(posicao+"\n\n");
                }

            }

            Console.WriteLine("O robô percorrerá cinco casas, o caminho mais curto até o objetivo. ");
            System.Console.ReadKey();

        }
    }
}
