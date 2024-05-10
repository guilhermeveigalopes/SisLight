using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLight
{
    class Lampada
    {
        private static int proximoCodigo = 1;
        public int Codigo { get; set; }
        public int Potencia { get; set; }
        public bool Acesa { get; set; }
        public Lampada(int potencia)
        {
            Codigo = proximoCodigo++;
            Potencia = potencia;
            Acesa = false;
        }
    }
}