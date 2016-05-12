using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMatriz
{
    class MinhaMatriz
    {
        public byte[,] matriz { get; set; }

        public MinhaMatriz(int i, int j)
        {
            this.matriz = new byte[i, j];
        }


    }
}
