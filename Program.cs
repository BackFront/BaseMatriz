using System;
using System.Collections.Generic;
using System.Text;

namespace BaseMatriz
{
	class Program
	{
        //**** Diagonal não conta como vizinho ****
        //**** Garantias: não existe terra nas bordas! ****
        //
        //teste 1
        //5
        //5
        //00000
        //01000
        //01100
        //00100
        //00000
        //
        //teste 2
        //10
        //10
        //0000000000
        //0100010000
        //0110000000
        //0010011100
        //0011110000
        //0000000000
        //0111001100
        //0000000000
        //0111110000
        //0000000000
        //
        //teste 3
        //10
        //10
        //0000000000
        //0100010000
        //0010000000
        //0010011100
        //0011100000
        //0000000000
        //0111001100
        //0000000000
        //0101010000
        //0000000000
        //
        static void Main(string[] args)
        {
            int linhas, colunas;

            linhas = int.Parse(Console.ReadLine());
            colunas = int.Parse(Console.ReadLine());

            byte[,] matriz = new byte[linhas, colunas];

            for (int l = 0; l < linhas; l++)
            {
                string linha = Console.ReadLine();
                for (int c = 0; c < colunas; c++)
                {
                    matriz[l, c] = (byte)(linha[c] - '0');
                }
            }
            MinhaMatriz NovaMatriz = new MinhaMatriz(linhas, colunas);
            NovaMatriz.matriz = matriz;

            //a partir daqui a matriz contém apenas 0's e 1's
            int totalIlhas = 0;
            for (int i = 0; i < linhas; ++i)
            {
                for (int j = 0; j < colunas; ++j)
                {
                    if (NovaMatriz.matriz[i, j] == 1)
                    {
                        Ilha.verVisinho(i,j,NovaMatriz.matriz);
                    }
                    ++totalIlhas;
                }
            }

            Console.WriteLine("A quantidade total de ilhas e: " + totalIlhas);
        }
    }

 
}


