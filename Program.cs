using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMedalhas_Matriz_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] medalhas = new int[10, 3];
            string[] paises = new string[10] { "BRA", "EUA", "JAP", "GER", "ARG", "URU", "CHI", "CAN", "AFS", "FRA" };
            int[] total = new int[10];
            int i, j, maior = 0;
            string nomeCampeao = "";

            //Preenchimento da MATRIZ:

            Random m = new Random();

            Console.WriteLine("\tOURO\tPRATA\tBRONZE"); //Imprime os paises na tela

            for (i = 0; i < medalhas.GetLength(0); i++) // i = linha
            {

                Console.Write(paises[i] + "\t"); //Imprime paises na tela

                for (j = 0; j < medalhas.GetLength(1); j++) // j =colunas
                {
                    medalhas[i, j] = m.Next(51); // 0 a 50
                    total[i] += medalhas[i, j];  //soma das limhas
                    Console.Write(medalhas[i, j] + "\t"); //Imprime a MATRIZ na tela
                }
                Console.WriteLine(" = " + total[i]); //quebra de linha quando terminar a linha

                //País campeão
                if (medalhas[i, 0] > maior) //coluna é fixa
                {
                    maior = medalhas[i, 0];
                    nomeCampeao = paises[i];
                }
            }

            Console.Write("País campeão:  " + nomeCampeao);


            Console.ReadKey();

        }
    }
}