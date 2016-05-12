using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMatriz
{
    class Ilha
    {
        public static byte[,] verVisinho(int linha, int coluna, byte[,] matriz)
        {
            matriz[linha, coluna] = 2;
            byte d = matriz[(linha - 1), (coluna)];
            byte a = matriz[(linha + 1), (coluna)];
            byte b = matriz[(linha+1), (coluna)];
            byte c = matriz[(linha+1), (coluna + 1)];
            

            if (a == 1) { matriz = Ilha.verVisinho((linha + 1), (coluna ), matriz); }
            if (b == 1) { matriz = Ilha.verVisinho((linha+1), (coluna), matriz); }
            if (c == 1) { matriz = Ilha.verVisinho((linha+1), (coluna + 1), matriz); }
            if (d == 1) { matriz = Ilha.verVisinho((linha + 2), (coluna + 1), matriz); }

            return matriz;
        }
    }
}
