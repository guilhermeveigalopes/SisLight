using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLight.Controladores
{
    class ConsultarPotenciaController
    {
        public static void ConsultarPotencia(List<Lampada> lampadas)
        {
            Console.WriteLine("Consultar Potência Utilizada");
            if (lampadas.Count == 0)
            {
                Console.WriteLine("Nenhuma lâmpada cadastrada!");
                Console.ReadKey();
                return;
            }

            int potenciaTotal = 0;

            foreach (var lampada in lampadas)
            {
                if (lampada.Acesa)
                {
                    potenciaTotal += lampada.Potencia;
                }
            }

            Console.WriteLine("Potência Total Utilizada: {0}W", potenciaTotal);
            Console.ReadKey();
        }
    }
}
