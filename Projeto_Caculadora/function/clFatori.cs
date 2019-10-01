using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Caculadora.function
{
    class clFatori
    {
        public double fatorial(double n1)
        {
            double resultado = 0;
            if(n1 > 0)
            {
                for(int i = 1; i <= n1; i++)
                {
                    resultado *= i;
                }
            }
            else
            {
                resultado  = -1;
            }
                return resultado;
        }
    }
}
